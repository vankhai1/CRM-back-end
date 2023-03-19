using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("LoaiNV")]
    public class LoaiNV
    {
        [Key]
        public int IdLoaiNV { get; set; }
        [Required]
        public string TenNV { get; set; }

        public virtual ICollection<NhiemVu> NhiemVus { get; set; }
    }
}
