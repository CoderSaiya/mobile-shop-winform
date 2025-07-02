using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_User")]
[Index("MobileNumber", Name = "UQ__tbl_User__250375B130BA30BC", IsUnique = true)]
public partial class TblUser
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("PWO")]
    [StringLength(256)]
    [Unicode(false)]
    public string Pwo { get; set; } = null!;

    [StringLength(256)]
    public string EmployeeName { get; set; } = null!;

    [StringLength(256)]
    public string Address { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MobileNumber { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Hint { get; set; }
}
