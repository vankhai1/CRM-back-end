using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRM_QLQHKH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrangThaiKHTNController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public TrangThaiKHTNController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.trangThaiKHTNs.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var trangthaikhtn = _context.trangThaiKHTNs.SingleOrDefault(cv => cv.IdTrangThai == id);
            if (trangthaikhtn != null)
            {
                return Ok(trangthaikhtn);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(TrangThaiKHTNRequest trangThaiKHTNRequest)
        {
            try
            {
                var trangthaikhtn = new TrangThaiKHTN
                {
                    TenTrangThai = trangThaiKHTNRequest.TenTrangThai,


                };
                _context.trangThaiKHTNs.Add(trangthaikhtn);
                _context.SaveChanges();
                return Ok(trangthaikhtn);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(int id, TrangThaiKHTNRequest trangThaiKHTNRequest)
        {
            var trangthaikhtn = _context.trangThaiKHTNs.SingleOrDefault(cv => cv.IdTrangThai == id);
            if (trangthaikhtn != null)
            {
                trangthaikhtn.TenTrangThai = trangthaikhtn.TenTrangThai;
                _context.SaveChanges();

                return Ok(trangthaikhtn);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(int id)
        {
            var trangthaikhtn = _context.trangThaiKHTNs.SingleOrDefault(cv => cv.IdTrangThai == id);
            if (trangthaikhtn != null)
            {
                _context.Remove(trangthaikhtn);
                _context.SaveChanges();
                return Ok(trangthaikhtn);
            }
            return NotFound();
        }
    }
}
