using CRM_QLQHKH.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CRM_QLQHKH.Models
{
    public class NhiemVuRequest
    {
        public string TenNhiemVu { get; set; }
        
        public DateTime HanChotNV { get; set; }
        
        public Guid? IdKHTN { get; set; }
        
        public int? IdLoaiNV { get; set; }
        
        public int? IdTrangThaiNV { get; set; }
    }
}
