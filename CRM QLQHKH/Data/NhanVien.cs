using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CRM_QLQHKH.Data
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string HoTen { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long SDT { get; set; }
        public string Hinh { get; set; }
        public Guid? IdTK { get; set; }
        [ForeignKey("IdTK")]
        public TaiKhoan TaiKhoan { get; set; }
        public int? IdCV { get; set; }
        [ForeignKey("IdCV")]
        public ChucVu chucVu { get; set; }
        public int? IdQuyen { get; set; }

        public virtual ICollection<KHTN> KHTNs { get; set; }
    }
}
