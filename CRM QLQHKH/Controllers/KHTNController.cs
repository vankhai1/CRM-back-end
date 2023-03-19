using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CRM_QLQHKH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KHTNController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public KHTNController(CRMDbContext context)
        {
            _context = context;

        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.KHTNs.ToList();
            
            return Ok(dsCv);
        }
       
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            var khtn = _context.KHTNs.SingleOrDefault(cv => cv.IdKHTN == id);
            if (khtn != null)
            {
                return Ok(khtn);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(KHTNRequest kHTNRequest)
        {
            try
            {
                var khtn = new KHTN
                {
                    HanChot = kHTNRequest.HanChot,
                    IdTrangThai = kHTNRequest.IdTrangThai,
                    IdLHKH= kHTNRequest.IdLHKH,
                    Id=kHTNRequest.Id

                };
                _context.KHTNs.Add(khtn);
                _context.SaveChanges();
                return Ok(khtn);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(Guid id, KHTNRequest kHTNRequest)
        {
            var khtn = _context.KHTNs.SingleOrDefault(cv => cv.IdKHTN == id);
            if (khtn != null)
            {
                khtn.HanChot = kHTNRequest.HanChot;
                khtn.IdTrangThai = kHTNRequest.IdTrangThai;
                khtn.IdLHKH = kHTNRequest.IdLHKH;
                khtn.Id = kHTNRequest.Id;
                _context.SaveChanges();

                return Ok(khtn);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(Guid id)
        {
            var khtn = _context.KHTNs.SingleOrDefault(cv => cv.IdKHTN == id);
            if (khtn != null)
            {
                _context.Remove(khtn);
                _context.SaveChanges();
                return Ok(khtn);
            }
            return NotFound();
        }
    }
}
