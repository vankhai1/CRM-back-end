using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public Guid IdTK { get; set; }
        [Required]
        public string TenTaiKhoan { get; set; }
        [Required]
        public string MatKhau { get; set; }


        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
