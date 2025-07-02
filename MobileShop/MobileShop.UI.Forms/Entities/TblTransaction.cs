using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_Transaction")]
public partial class TblTransaction
{
    [Key]
    public int TransId { get; set; }

    public int ModelId { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("TblTransactions")]
    public virtual TblModel Model { get; set; } = null!;
}
