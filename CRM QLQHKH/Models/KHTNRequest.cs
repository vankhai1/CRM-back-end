using CRM_QLQHKH.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CRM_QLQHKH.Models
{
    public class KHTNRequest
    {
        public DateTime HanChot { get; set; }

        public int? IdTrangThai { get; set; }
        
        public Guid? IdLHKH { get; set; }

        public Guid? Id { get; set; }
        
       
    }
}
