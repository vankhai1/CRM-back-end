using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("TrangThaiKHTN")]
    public class TrangThaiKHTN
    {
        [Key]
        public int IdTrangThai { get; set; }
        [Required]
        public string TenTrangThai { get; set; }

        public virtual ICollection<KHTN> KHTNs { get; set; }
    }
}
