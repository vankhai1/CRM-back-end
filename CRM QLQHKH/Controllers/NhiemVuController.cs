using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRM_QLQHKH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhiemVuController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public NhiemVuController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.nhiemVus.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var nhiemvu = _context.nhiemVus.SingleOrDefault(cv => cv.IdNV == id);
            if (nhiemvu != null)
            {
                return Ok(nhiemvu);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(NhiemVuRequest nhiemVuRequest)
        {
            try
            {
                var nhiemvu = new NhiemVu
                {
                    TenNhiemVu = nhiemVuRequest.TenNhiemVu,
                    HanChotNV = nhiemVuRequest.HanChotNV,
                    IdKHTN = nhiemVuRequest.IdKHTN,
                    IdLoaiNV = nhiemVuRequest.IdLoaiNV,
                    IdTrangThaiNV = nhiemVuRequest.IdTrangThaiNV,


                };
                _context.nhiemVus.Add(nhiemvu);
                _context.SaveChanges();
                return Ok(nhiemvu);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(int id, NhiemVuRequest nhiemVuRequest)
        {
            var nhiemvu = _context.nhiemVus.SingleOrDefault(cv => cv.IdNV == id);
            if (nhiemvu != null)
            {
                nhiemvu.TenNhiemVu = nhiemVuRequest.TenNhiemVu;
                nhiemvu.HanChotNV = nhiemVuRequest.HanChotNV;
                nhiemvu.IdKHTN = nhiemVuRequest.IdKHTN;
                nhiemvu.IdLoaiNV = nhiemVuRequest.IdLoaiNV;
                nhiemvu.IdTrangThaiNV = nhiemVuRequest.IdTrangThaiNV;
                _context.SaveChanges();

                return Ok(nhiemvu);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(int id)
        {
            var nhiemvu = _context.nhiemVus.SingleOrDefault(cv => cv.IdNV == id);
            if (nhiemvu != null)
            {
                _context.Remove(nhiemvu);
                _context.SaveChanges();
                return Ok(nhiemvu);
            }
            return NotFound();
        }
    }
}
