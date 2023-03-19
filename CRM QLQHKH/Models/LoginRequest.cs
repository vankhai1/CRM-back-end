using System.ComponentModel.DataAnnotations;

namespace CRM_QLQHKH.Models
{
    public class LoginRequest
    {
        [Required]
        public string TenTaiKhoan { get; set; }
        [Required]
        public string MatKhau { get; set; }

    }
}
