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
    public class NhanVienController : ControllerBase
    {
        private readonly CRMDbContext _context;

        public NhanVienController(CRMDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsCv = _context.NhanViens.ToList();
            return Ok(dsCv);
        }
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            var nhanvien = _context.NhanViens.SingleOrDefault(cv => cv.Id == id);
            if (nhanvien != null)
            {
                return Ok(nhanvien);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNew(NhanVienRequest nhanVienRequest)
        {
            try
            {
                var nhanvien = new NhanVien
                {
                    HoTen = nhanVienRequest.HoTen,
                    DiaChi = nhanVienRequest.DiaChi,
                    Email = nhanVienRequest.Email,
                    SDT = nhanVienRequest.SDT,
                    Hinh = nhanVienRequest.Hinh,
                    IdTK = nhanVienRequest.IdTK,
                    IdCV = nhanVienRequest.IdCV,
                    IdQuyen = nhanVienRequest.IdQuyen,



                };
                _context.NhanViens.Add(nhanvien);
                _context.SaveChanges();
                return Ok(nhanvien);
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPut("id")]
        public IActionResult UpdateById(Guid id, NhanVienRequest nhanVienRequest)
        {
            var nhanvien = _context.NhanViens.SingleOrDefault(cv => cv.Id == id);
            if (nhanvien != null)
            {
                nhanvien.HoTen = nhanVienRequest.HoTen;
                nhanvien.DiaChi = nhanVienRequest.DiaChi;
                nhanvien.Email = nhanVienRequest.Email;
;                    nhanvien.Hinh = nhanVienRequest.Hinh;
                nhanvien.IdTK = nhanVienRequest.IdTK;
                nhanvien.IdCV = nhanVienRequest.IdCV;
                nhanvien.IdQuyen = nhanVienRequest.IdQuyen;
                _context.SaveChanges();

                return Ok(nhanvien);
            }

            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteById(Guid id)
        {
            var nhanvien = _context.NhanViens.SingleOrDefault(cv => cv.Id == id);
            if (nhanvien != null)
            {
                _context.Remove(nhanvien);
                _context.SaveChanges();
                return Ok(nhanvien);
            }
            return NotFound();
        }
    }
}
