using System.ComponentModel.DataAnnotations;

namespace udonthani_link_api.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;

        public ICollection<UserRole>? UserRoles { get; set; }
    }
}