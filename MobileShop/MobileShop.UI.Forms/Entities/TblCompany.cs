using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_Company")]
[Index("Cname", Name = "UQ__tbl_Comp__85D445AAE936EB62", IsUnique = true)]
public partial class TblCompany
{
    [Key]
    public int ComId { get; set; }

    [Column("CName")]
    [StringLength(256)]
    public string Cname { get; set; } = null!;

    [InverseProperty("Com")]
    public virtual ICollection<TblModel> TblModels { get; set; } = new List<TblModel>();
}
