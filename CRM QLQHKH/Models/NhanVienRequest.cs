using CRM_QLQHKH.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CRM_QLQHKH.Models
{
    public class NhanVienRequest
    {
        public string HoTen { get; set; }
        
        public string DiaChi { get; set; }
        
        public string Email { get; set; }
       
        public long SDT { get; set; }
        public string Hinh { get; set; }
        public Guid? IdTK { get; set; }
           
        public int? IdCV { get; set; }

        public int? IdQuyen { get; set; }
    }
}
