using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.UI.Forms.Entities;

[Table("tbl_Customer")]
[Index("MobileNumber", Name = "UQ__tbl_Cust__250375B10DC4EDE8", IsUnique = true)]
[Index("EmailId", Name = "UQ__tbl_Cust__7ED91ACE4CD0421F", IsUnique = true)]
public partial class TblCustomer
{
    [Key]
    public int CustId { get; set; }

    [Column("Cust_Name")]
    [StringLength(256)]
    public string CustName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MobileNumber { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? EmailId { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? Address { get; set; }

    [InverseProperty("Cust")]
    public virtual ICollection<TblSale> TblSales { get; set; } = new List<TblSale>();
}
