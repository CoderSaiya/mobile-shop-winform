using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MobileShop.UI.Forms.Entities;

namespace MobileShop.UI.Forms.Data;

public partial class PhoneShopDbContext : DbContext
{
    public PhoneShopDbContext()
    {
    }

    public PhoneShopDbContext(DbContextOptions<PhoneShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblMobile> TblMobiles { get; set; }

    public virtual DbSet<TblModel> TblModels { get; set; }

    public virtual DbSet<TblSale> TblSales { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-1FAVEMH\\SQLEXPRESS;Initial Catalog=PhoneShopDB;Integrated Security=True;trusted_connection=true;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.HasKey(e => e.ComId).HasName("PK__tbl_Comp__E15F41127CA01EF1");
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.HasKey(e => e.CustId).HasName("PK__tbl_Cust__049E3AA9EBB1C9F1");
        });

        modelBuilder.Entity<TblMobile>(entity =>
        {
            entity.HasKey(e => e.Imeino).HasName("PK__tbl_Mobi__60553A220A45C759");

            entity.Property(e => e.Imeino).IsFixedLength();

            entity.HasOne(d => d.Model).WithMany(p => p.TblMobiles).HasConstraintName("FK_Mobile_Model");
        });

        modelBuilder.Entity<TblModel>(entity =>
        {
            entity.HasKey(e => e.ModelId).HasName("PK__tbl_Mode__E8D7A12C74A1A7DB");

            entity.Property(e => e.AvailableQty).HasDefaultValue(true);

            entity.HasOne(d => d.Com).WithMany(p => p.TblModels).HasConstraintName("FK_Model_Company");
        });

        modelBuilder.Entity<TblSale>(entity =>
        {
            entity.HasKey(e => e.SlsId).HasName("PK__tbl_Sale__26AFF4389384F79B");

            entity.Property(e => e.Imeino).IsFixedLength();
            entity.Property(e => e.PurchaseDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Cust).WithMany(p => p.TblSales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Customer");

            entity.HasOne(d => d.ImeinoNavigation).WithOne(p => p.TblSale).HasConstraintName("FK_Sales_Mobile");
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__tbl_Tran__9E5DDB3C10770194");

            entity.Property(e => e.Date).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Model).WithMany(p => p.TblTransactions).HasConstraintName("FK_Transaction_Model");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__tbl_User__536C85E58A18BC81");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
