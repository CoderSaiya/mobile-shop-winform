USE PhoneShopDB;
GO

CREATE TABLE dbo.tbl_User (
	Username VARCHAR(50) PRIMARY KEY,
	PWO VARCHAR(256) NOT NULL,
	EmployeeName NVARCHAR(256) NOT NULL,
	Address NVARCHAR(256) NOT NULL,
	MobileNumber VARCHAR(50) NOT NULL UNIQUE,
	Hint VARCHAR(50) NULL,

	CONSTRAINT CHK_MobileNumber
	CHECK (MobileNumber LIKE '+%' OR MobileNumber LIKE '[0-9]%'),
);
GO

CREATE TABLE dbo.tbl_Company (
	ComId INT IDENTITY(1,1) PRIMARY KEY,
	CName NVARCHAR(256) NOT NULL UNIQUE
);
GO

CREATE TABLE dbo.tbl_Model (
	ModelId INT IDENTITY(1,1) PRIMARY KEY,
	ComId INT NOT NULL,
	ModelNum VARCHAR(256) NOT NULL UNIQUE,
	AvailableQty BIT DEFAULT(1),
	CONSTRAINT FK_Model_Company FOREIGN KEY (ComId)
        REFERENCES tbl_Company(ComId)
	ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE dbo.tbl_Transaction (
	TransId INT IDENTITY(1,1) PRIMARY KEY,
	ModelId INT NOT NULL,
	Quantity INT NOT NULL DEFAULT(0),
	Date DATETIME NOT NULL DEFAULT SYSUTCDATETIME(),
	Amount DECIMAL(18,2) NOT NULL,

	CONSTRAINT CHK_Trans_Quantity_NonNeg CHECK (Quantity >= 0),
    CONSTRAINT CHK_Trans_Amount_NonNeg CHECK (Amount >= 0),

	CONSTRAINT FK_Transaction_Model FOREIGN KEY (ModelId)
        REFERENCES tbl_Model(ModelId)
	ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE dbo.tbl_Mobile (
	ModelId INT NOT NULL,
	IMEINO CHAR(15) PRIMARY KEY,
	Status NVARCHAR(50) NOT NULL,
	Warranty DATE NULL,
	Price DECIMAL(18,2) NOT NULL DEFAULT(0),

	CONSTRAINT CHK_Mobile_Price_NonNeg CHECK (Price >= 0),
    CONSTRAINT CHK_Mobile_IMEI_Format CHECK (IMEINO NOT LIKE '%[^0-9]%'),

	CONSTRAINT FK_Mobile_Model FOREIGN KEY (ModelId)
        REFERENCES tbl_Model(ModelId)
	ON DELETE CASCADE
    ON UPDATE NO ACTION
);

CREATE TABLE dbo.tbl_Customer (
	CustId INT IDENTITY(1,1) PRIMARY KEY,
	Cust_Name NVARCHAR(256) NOT NULL,
	MobileNumber VARCHAR(50) NULL UNIQUE,
	EmailId VARCHAR(256) NULL UNIQUE,
	Address VARCHAR(256) NULL,

	CONSTRAINT CHK_Cust_MobileFormat CHECK (
        MobileNumber IS NULL
        OR MobileNumber LIKE '+[0-9]%'
        OR MobileNumber LIKE '[0-9]%'
    ),
	CONSTRAINT CHK_Cust_EmailFormat CHECK (
        EmailId IS NULL
        OR EmailId LIKE '%_@__%.__%'
    )
);

CREATE TABLE dbo.tbl_Sales (
	SlsId INT IDENTITY(1,1) PRIMARY KEY,
	IMEINO CHAR(15) NOT NULL UNIQUE,
	PurchaseDate DATETIME NOT NULL DEFAULT GETDATE(),
	SalePrice DECIMAL(18,2) NOT NULL DEFAULT(0),
	CustId INT NOT NULL,

	CONSTRAINT FK_Sales_Mobile FOREIGN KEY (IMEINO)
        REFERENCES tbl_Mobile(IMEINO)
	ON DELETE CASCADE
    ON UPDATE NO ACTION,
	CONSTRAINT FK_Sales_Customer FOREIGN KEY(CustId)
        REFERENCES dbo.tbl_Customer(CustId)
    ON UPDATE CASCADE
    ON DELETE NO ACTION,
);

ALTER TABLE dbo.tbl_User
ADD Role NVARCHAR(50) NOT NULL
	CONSTRAINT DF_tbl_User_Role DEFAULT('Customer');

ALTER TABLE dbo.tbl_Mobile
ADD Stock INT NOT NULL DEFAULT(0);
GO

CREATE OR ALTER TRIGGER trg_Mobile_Insert
ON dbo.tbl_Mobile
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE m
    SET Stock = 1
    FROM dbo.tbl_Mobile AS m
    JOIN inserted AS i ON m.IMEINO = i.IMEINO;
END;
GO

CREATE OR ALTER TRIGGER trg_Mobile_Update
ON dbo.tbl_Mobile
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE m
    SET Stock = 
        CASE 
            WHEN i.Status = 'Available' THEN 1
            WHEN i.Status = 'Sold' THEN 0
            ELSE m.Stock
        END
    FROM dbo.tbl_Mobile AS m
    JOIN inserted AS i ON m.IMEINO = i.IMEINO;
END;
GO

CREATE OR ALTER TRIGGER trg_Mobile_Delete
ON dbo.tbl_Mobile
AFTER DELETE
AS
BEGIN
    RETURN;
END;
GO

-- Tìm tên Unique
SELECT
  kc.name AS ConstraintName,
  ic.index_column_id,
  col.name AS ColumnName
FROM sys.key_constraints kc
  JOIN sys.index_columns ic
    ON kc.unique_index_id = ic.index_id
    AND kc.parent_object_id = ic.object_id
  JOIN sys.columns col
    ON ic.column_id = col.column_id
    AND ic.object_id = col.object_id
WHERE kc.parent_object_id = OBJECT_ID('dbo.tbl_Sales')
  AND kc.type = 'UQ';

ALTER TABLE dbo.tbl_Sales
	DROP CONSTRAINT UQ__tbl_Sale__60553A2324D88B20;

-- xoa phan stock o mobile
ALTER TABLE dbo.tbl_Mobile DROP CONSTRAINT IF EXISTS CHK_Mobile_Price_NonNeg;
ALTER TABLE dbo.tbl_Mobile DROP CONSTRAINT IF EXISTS CHK_Mobile_IMEI_Format;
ALTER TABLE dbo.tbl_Mobile DROP CONSTRAINT IF EXISTS FK_Mobile_Model;
DROP TRIGGER IF EXISTS trg_Mobile_Insert;
DROP TRIGGER IF EXISTS trg_Mobile_Update;
DROP TRIGGER IF EXISTS trg_Mobile_Delete;

DECLARE @df_name sysname;

-- 1. Lấy tên default constraint gán cho cột Stock
SELECT @df_name = dc.name
FROM sys.default_constraints dc
JOIN sys.columns c
  ON dc.parent_object_id = c.object_id
 AND dc.parent_column_id = c.column_id
WHERE OBJECT_NAME(dc.parent_object_id) = 'tbl_Mobile'
  AND c.name = 'Stock';

-- 2. Nếu tìm thấy thì xoá constraint đó
IF @df_name IS NOT NULL
BEGIN
    PRINT 'Dropping default constraint ' + @df_name;
    EXEC('ALTER TABLE dbo.tbl_Mobile DROP CONSTRAINT [' + @df_name + ']');
END
ELSE
    PRINT 'No default constraint found on dbo.tbl_Mobile.Stock';

ALTER TABLE dbo.tbl_Mobile
    DROP COLUMN Stock;

-- Thêm cột Stock vào tbl_Model
ALTER TABLE dbo.tbl_Model
    ADD Stock INT NOT NULL DEFAULT(0);


-- Tạo trigger tự động update Stock trên tbl_Model
CREATE OR ALTER TRIGGER trg_Update_ModelStock
ON dbo.tbl_Mobile
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật stock cho tất cả các model đã bị ảnh hưởng
    WITH affected AS (
        SELECT ModelId FROM inserted
        UNION
        SELECT ModelId FROM deleted
    )
    UPDATE m
    SET m.Stock = (
        SELECT COUNT(*) 
        FROM dbo.tbl_Mobile AS mb
        WHERE mb.ModelId = m.ModelId
          AND mb.Status = 'Available'
    )
    FROM dbo.tbl_Model AS m
    JOIN affected AS a ON m.ModelId = a.ModelId;
END;
GO

-- Thêm cột image và name vào mobile
ALTER TABLE dbo.tbl_Mobile
ADD Image NVARCHAR(256) NULL;

ALTER TABLE dbo.tbl_Mobile
ADD Name NVARCHAR(256) NULL;
GO

-- Thêm default cho trạng thái của mobile
ALTER TABLE dbo.tbl_Mobile
ADD CONSTRAINT DF_tbl_Mobile_Status DEFAULT('Available') FOR Status;
GO

-- Đổi giá trị default của User role từ 'Customer' sang 'Employee'
-- 1. Xóa default constraint cũ
ALTER TABLE dbo.tbl_User
DROP CONSTRAINT DF_tbl_User_Role;
GO

-- 2. Thêm default mới
ALTER TABLE dbo.tbl_User
ADD CONSTRAINT DF_tbl_User_Role
    DEFAULT('Employee') FOR Role;
GO

DROP TABLE IF EXISTS dbo.tbl_Sales
DROP TABLE IF EXISTS dbo.tbl_Customer
DROP TABLE IF EXISTS dbo.tbl_Mobile
DROP TABLE IF EXISTS dbo.tbl_Transaction
DROP TABLE IF EXISTS dbo.tbl_Model
DROP TABLE IF EXISTS dbo.tbl_Company
DROP TABLE IF EXISTS dbo.tbl_User

SELECT * FROM dbo.tbl_Company
SELECT * FROM dbo.tbl_User
SELECT * FROM dbo.tbl_Mobile
SELECT * FROM dbo.tbl_Model
SELECT * FROM dbo.tbl_Transaction
SELECT * FROM dbo.tbl_Sales
SELECT * FROM dbo.tbl_Customer