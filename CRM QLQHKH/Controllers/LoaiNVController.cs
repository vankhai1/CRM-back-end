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
    public class LoaiNVController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public LoaiNVController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.loaiNVs.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var loainv = _context.loaiNVs.SingleOrDefault(cv => cv.IdLoaiNV == id);
            if (loainv != null)
            {
                return Ok(loainv);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(LoaiNVRequest loaiNVRequest)
        {
            try
            {
                var loainv = new LoaiNV
                {
                    TenNV = loaiNVRequest.TenNV,
                    
                    


                };
                _context.loaiNVs.Add(loainv);
                _context.SaveChanges();
                return Ok(loainv);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(int id, LoaiNVRequest loaiNVRequest)
        {
            var loainv = _context.loaiNVs.SingleOrDefault(cv => cv.IdLoaiNV == id);
            if (loainv != null)
            {
                loainv.TenNV = loaiNVRequest.TenNV;
                
                _context.SaveChanges();

                return Ok(loainv);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(int id)
        {
            var loainv = _context.loaiNVs.SingleOrDefault(cv => cv.IdLoaiNV == id);
            if (loainv != null)
            {
                _context.Remove(loainv);
                _context.SaveChanges();
                return Ok(loainv);
            }
            return NotFound();
        }
    }
}
