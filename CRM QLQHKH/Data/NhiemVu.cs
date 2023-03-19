using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("NhiemVu")]
    public class NhiemVu
    {
        [Key]
        public int IdNV { get; set; }
        [Required]
        public string TenNhiemVu { get;set; }
        [Required]
        public DateTime HanChotNV { get; set; }
        [Required]
        public Guid? IdKHTN { get; set; }
        [ForeignKey ("IdKHTN")]
        public KHTN kHTN { get; set; }
        [Required]
        public int? IdLoaiNV { get;set;}
        [ForeignKey("IdLoai")]
        public LoaiNV loaiNV { get; set; }
        [Required]
        public int? IdTrangThaiNV { get; set; }
        [ForeignKey("IdTrangThaiNV")]
        public TrangThaiNV trangThaiNV { get; set; }

        
    }
}
