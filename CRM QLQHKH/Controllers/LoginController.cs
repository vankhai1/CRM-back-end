using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRM_QLQHKH.Data;
using CRM_QLQHKH.Models;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;

namespace QLKH_CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly CRMDbContext _context;
        private readonly AppSetting _appSetting;

        public LoginController(CRMDbContext context, IOptionsMonitor<AppSetting>optionsMonitor)
        {
            _context = context;
            _appSetting = optionsMonitor.CurrentValue;
        }
        [HttpPost("Login")]
        public IActionResult Validate(LoginRequest loginRequest)
        {
            var taiKhoan=_context.TaiKhoans.SingleOrDefault(p=>p.TenTaiKhoan == loginRequest.TenTaiKhoan && loginRequest.MatKhau==p.MatKhau);
            if (taiKhoan == null)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message="Invalid Username/password",
                });
            }return Ok(new ApiResponse
            {
                Success=true,
                Message="Authenticate success",
                Data =GenerateToken(taiKhoan)
            });
        }
        private string GenerateToken(TaiKhoan taiKhoan)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.UTF8.GetBytes(_appSetting.SecretKey);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {   new Claim(ClaimTypes.Name, taiKhoan.TenTaiKhoan),
                    new Claim("IdTK",taiKhoan.IdTK.ToString()),
                    new Claim("TokenId",Guid.NewGuid().ToString())

                }),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha512Signature),
            };
            var token = jwtTokenHandler.CreateToken(tokenDescription);
            return jwtTokenHandler.WriteToken(token);
        }
    }
}
