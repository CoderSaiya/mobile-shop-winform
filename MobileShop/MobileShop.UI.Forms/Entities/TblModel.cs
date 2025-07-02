using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_Model")]
[Index("ModelNum", Name = "UQ__tbl_Mode__E2618C18F0BA6EA4", IsUnique = true)]
public partial class TblModel
{
    [Key]
    public int ModelId { get; set; }

    public int ComId { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string ModelNum { get; set; } = null!;

    public bool? AvailableQty { get; set; }

    [ForeignKey("ComId")]
    [InverseProperty("TblModels")]
    public virtual TblCompany Com { get; set; } = null!;

    [InverseProperty("Model")]
    public virtual ICollection<TblMobile> TblMobiles { get; set; } = new List<TblMobile>();

    [InverseProperty("Model")]
    public virtual ICollection<TblTransaction> TblTransactions { get; set; } = new List<TblTransaction>();
}
