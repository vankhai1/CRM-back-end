using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using System.Linq;

namespace QLKH_CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public ChucVuController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.ChucVus.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var chucvu = _context.ChucVus.SingleOrDefault(cv =>cv.IdCV == id);
            if (chucvu != null)
            {
                return Ok(chucvu);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(ChucVuRequest chucVuRequest)
        {
            try
            {
                var chucvu = new ChucVu
                {
                    TenChucVu = chucVuRequest.TenChucVu,
                    MoTa = chucVuRequest.MoTa

                };
                _context.ChucVus.Add(chucvu);
                _context.SaveChanges();
                return Ok(chucvu);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(int id, ChucVuRequest chucVuRequest)
        {
            var chucvu = _context.ChucVus.SingleOrDefault(cv => cv.IdCV == id);
            if (chucvu != null)
            {
                chucvu.TenChucVu = chucVuRequest.TenChucVu;
                chucvu.MoTa = chucVuRequest.MoTa;
                _context.SaveChanges();

                return Ok(chucvu);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(int id)
        {
            var chucvu = _context.ChucVus.SingleOrDefault(cv => cv.IdCV == id);
            if (chucvu != null)
            {
                _context.Remove(chucvu);
                _context.SaveChanges();
                return Ok(chucvu);
            }
            return NotFound();
        }
    }
}
