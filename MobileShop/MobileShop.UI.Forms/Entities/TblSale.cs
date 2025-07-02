using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_Sales")]
[Index("Imeino", Name = "UQ__tbl_Sale__60553A2324D88B20", IsUnique = true)]
public partial class TblSale
{
    [Key]
    public int SlsId { get; set; }

    [Column("IMEINO")]
    [StringLength(15)]
    [Unicode(false)]
    public string Imeino { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SalePrice { get; set; }

    public int CustId { get; set; }

    [ForeignKey("CustId")]
    [InverseProperty("TblSales")]
    public virtual TblCustomer Cust { get; set; } = null!;

    [ForeignKey("Imeino")]
    [InverseProperty("TblSale")]
    public virtual TblMobile ImeinoNavigation { get; set; } = null!;
}
