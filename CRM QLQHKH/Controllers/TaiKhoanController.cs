using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using System.Linq;
using System;

namespace QLKH_CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public TaiKhoanController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsTk=_context.TaiKhoans.ToList();
            return Ok(dsTk);
        }
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            var taiKhoan = _context.TaiKhoans.SingleOrDefault(tk => tk.IdTK == id);
            if(taiKhoan != null)
            {
                return Ok(taiKhoan);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(TaiKhoanRequest taiKhoanRequest)
        {
            try
            {
                var taikhoan = new TaiKhoan
                {
                    TenTaiKhoan = taiKhoanRequest.TenTaiKhoan,
                    MatKhau = taiKhoanRequest.MatKhau

                };
                _context.TaiKhoans.Add(taikhoan);
                _context.SaveChanges();
                return Ok(taikhoan);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(Guid id, TaiKhoanRequest taiKhoanRequest)
        {
            var taiKhoan = _context.TaiKhoans.SingleOrDefault(tk => tk.IdTK == id);
            if (taiKhoan != null)
            {
                taiKhoan.TenTaiKhoan = taiKhoanRequest.TenTaiKhoan;
                taiKhoan.MatKhau = taiKhoanRequest.MatKhau;
                _context.SaveChanges();

                return Ok(taiKhoan);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(Guid id)
        {
            var taikhoan = _context.TaiKhoans.SingleOrDefault(tk => tk.IdTK == id);
            if (taikhoan != null)
            {
                _context.Remove(taikhoan);
                _context.SaveChanges();
                return Ok(taikhoan);
            }
            return NotFound();
        }
    }
}
