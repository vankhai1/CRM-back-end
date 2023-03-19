using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_QLQHKH.Data
{
    [Table("LHKH")]
    public class LHKH
    {
        [Key]
        public Guid IdLHKH { get; set; }
        [Required]
        public string HoTenKH { get; set; }
        [Required]
        public string EmailKH { get; set; }
        [Required]
        public long SDTKH { get; set; }
        [Required]
        public DateTime NSKH { get; set;}
        public string TieuDe { get; set;}

        public virtual ICollection<KHTN> KHTNs { get; set; }
    }
}
