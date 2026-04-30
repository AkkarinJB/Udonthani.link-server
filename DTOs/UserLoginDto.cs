using System.ComponentModel.DataAnnotations;
namespace udonthani_link_api.DTOs;

    public class UserLoginDto
{
    [Required(ErrorMessage = "กรุณากรอกอีเมล")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "กรุณากรอกรหัสผ่าน")]
    public string Password { get; set; } = string.Empty;
}