using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRM_QLQHKH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrangThaiNVController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public TrangThaiNVController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.trangThaiNVs.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var trangthainv = _context.trangThaiNVs.SingleOrDefault(cv => cv.IdTrangThaiNV == id);
            if (trangthainv != null)
            {
                return Ok(trangthainv);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(TrangThaiNVRequest trangThaiNVRequest)
        {
            try
            {
                var trangthainv = new TrangThaiNV
                {
                    TenTrangThaiNV = trangThaiNVRequest.TenTrangThaiNV,
                    

                };
                _context.trangThaiNVs.Add(trangthainv);
                _context.SaveChanges();
                return Ok(trangthainv);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(int id, TrangThaiNVRequest trangThaiNVRequest)
        {
            var trangthainv = _context.trangThaiNVs.SingleOrDefault(cv => cv.IdTrangThaiNV == id);
            if (trangthainv != null)
            {
                trangthainv.TenTrangThaiNV = trangThaiNVRequest.TenTrangThaiNV;
                _context.SaveChanges();

                return Ok(trangthainv);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(int id)
        {
            var trangthainv = _context.trangThaiNVs.SingleOrDefault(cv => cv.IdTrangThaiNV == id);
            if (trangthainv != null)
            {
                _context.Remove(trangthainv);
                _context.SaveChanges();
                return Ok(trangthainv);
            }
            return NotFound();
        }
    }
}
