using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("MaNV")]
    [StringLength(4)]
    [Unicode(false)]
    public string MaNv { get; set; } = null!;

    [StringLength(30)]
    public string? HoTen { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySinh { get; set; }

    [StringLength(3)]
    public string? GioiTinh { get; set; }

    [StringLength(30)]
    public string? Diachi { get; set; }
}
