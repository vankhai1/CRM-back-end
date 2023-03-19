using System.ComponentModel.DataAnnotations;
using System;

namespace CRM_QLQHKH.Models
{
    public class LHKHRequest
    {
        public string HoTenKH { get; set; }
        
        public string EmailKH { get; set; }
        
        public long SDTKH { get; set; }
        
        public DateTime NSKH { get; set; }
        public string TieuDe { get; set; }
    }
}
