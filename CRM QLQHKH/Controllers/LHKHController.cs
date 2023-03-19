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
    public class LHKHController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public LHKHController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.LHKHs.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            var lhkh = _context.LHKHs.SingleOrDefault(cv => cv.IdLHKH == id);
            if (lhkh != null)
            {
                return Ok(lhkh);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(LHKHRequest lHKHRequest)
        {
            try
            {
                var lhkh = new LHKH
                {
                    HoTenKH = lHKHRequest.HoTenKH,
                    EmailKH = lHKHRequest.EmailKH,
                    SDTKH = lHKHRequest.SDTKH,
                    NSKH = lHKHRequest.NSKH,
                    TieuDe = lHKHRequest.TieuDe,


                };
                _context.LHKHs.Add(lhkh);
                _context.SaveChanges();
                return Ok(lhkh);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(Guid id, LHKHRequest lHKHRequest)
        {
            var lhkh = _context.LHKHs.SingleOrDefault(cv => cv.IdLHKH == id);
            if (lhkh != null)
            {
                lhkh.HoTenKH = lHKHRequest.HoTenKH;
                lhkh.EmailKH = lHKHRequest.EmailKH;
                lhkh.SDTKH = lHKHRequest.SDTKH;
                lhkh.NSKH = lHKHRequest.NSKH;
                lhkh.TieuDe = lHKHRequest.TieuDe;
                _context.SaveChanges();

                return Ok(lhkh);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(Guid id)
        {
            var lhkh = _context.LHKHs.SingleOrDefault(cv => cv.IdLHKH == id);
            if (lhkh != null)
            {
                _context.Remove(lhkh);
                _context.SaveChanges();
                return Ok(lhkh);
            }
            return NotFound();
        }
    }
}
