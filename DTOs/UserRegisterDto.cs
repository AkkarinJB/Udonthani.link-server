using System.ComponentModel.DataAnnotations;
namespace udonthani_link_api.DTOs;

    public class UserRegisterDto
{
    [Required(ErrorMessage = "กรุณากรอกอีเมล")]
    [EmailAddress(ErrorMessage = "รูปเเบบอีเมลไม่ถูกต้อง")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "กรูณาระบุรหัสผ่าน")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "กรุณาระบุประเภทที่ต้องการ หางาน หรือ บริษัท ")]
    public string Role { get; set; } = string.Empty;

}


    
