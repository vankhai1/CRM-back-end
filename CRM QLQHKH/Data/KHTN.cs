using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CRM_QLQHKH.Data
{
    [Table("KHTN")]
    
    
    public class KHTN
    {
        [Key]
        public Guid IdKHTN { get; set; }
        [Required , MaxLength (100)]
        public DateTime HanChot { get; set; }

        [Required]
        public int? IdTrangThai { get; set; }
        [ForeignKey("IdTrangThai")]
        public TrangThaiKHTN trangThaiKHTN { get; set; }
        [Required]
        public Guid? IdLHKH { get; set; }
        [ForeignKey("IdLHKH")]
        public LHKH lHKH { get; set; }
        [Required]
        public Guid? Id { get; set; }
        [ForeignKey ("Id")]
        public NhanVien nhanVien { get; set; }


        public virtual ICollection<NhiemVu> NhiemVus { get; set; }
    }
}
