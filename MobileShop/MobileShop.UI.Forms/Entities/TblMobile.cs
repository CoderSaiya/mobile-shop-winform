using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_Mobile")]
public partial class TblMobile
{
    public int ModelId { get; set; }

    [Key]
    [Column("IMEINO")]
    [StringLength(15)]
    [Unicode(false)]
    public string Imeino { get; set; } = null!;

    [StringLength(50)]
    public string Status { get; set; } = null!;

    public DateOnly? Warranty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("TblMobiles")]
    public virtual TblModel Model { get; set; } = null!;

    [InverseProperty("ImeinoNavigation")]
    public virtual TblSale? TblSale { get; set; }
}
