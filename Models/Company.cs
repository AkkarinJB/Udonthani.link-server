using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udonthani_link_api.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        public string? TaxId { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }
        public string? LogoUrl { get; set; }
        public bool IsVerified { get; set; } = false;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // 1 บริษัท มีได้หลายประกาศงาน
        public ICollection<JobPost>? JobPosts { get; set; }
    }
}