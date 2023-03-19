using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("ChucVu")]
    public class ChucVu
    {
        [Key]
        public int IdCV { get; set; }
        [Required]
        public string TenChucVu { get; set; }
        [MaxLength(200)]
        public string MoTa { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
