using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using udonthani_link_api.Data;
using udonthani_link_api.DTOs;
using udonthani_link_api.Models;

namespace udonthani_link_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto request)
        {
            if (await _context.Users.AnyAsync(u => u.Email == request.Email))
            {
                return BadRequest("อีเมลนี้ถูกใช้งานแล้วครับ");
            }

            string passwordHash = request.Password;

            var newUser = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(new { message = "สมัตรสมาชิกสำเร็จ", userId = newUser.Id });
        }
    }
}