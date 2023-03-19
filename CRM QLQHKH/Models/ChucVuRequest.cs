using System.ComponentModel.DataAnnotations;

namespace CRM_QLQHKH.Models
{
    public class ChucVuRequest
    {
        public int IdCV { get; set; }
        [Required]
        public string TenChucVu { get; set; }
        [MaxLength(200)]
        public string MoTa { get; set; }
    }
}
