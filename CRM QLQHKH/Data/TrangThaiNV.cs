using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("TrangThaiNV")]
    public class TrangThaiNV
    {
        [Key]
        public int IdTrangThaiNV { get; set; }
        [Required]
        public string TenTrangThaiNV { get; set; }

        public virtual ICollection<NhiemVu> NhiemVus { get; set; }
    }
}
