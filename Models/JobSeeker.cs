using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udonthani_link_api.Models
{
    public class JobSeeker
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Summary { get; set; }
        public string? ResumeUrl { get; set; }
        public string? ProfileImageUrl { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // 1 คน กดสมัครได้หลายงาน
        public ICollection<Application>? Applications { get; set; }
    }
}