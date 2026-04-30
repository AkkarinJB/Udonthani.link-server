using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udonthani_link_api.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        public int JobPostId { get; set; }
        [ForeignKey("JobPostId")]
        public JobPost? JobPost { get; set; }

        public int JobSeekerId { get; set; }
        [ForeignKey("JobSeekerId")]
        public JobSeeker? JobSeeker { get; set; }

        public string Status { get; set; } = "Pending"; // Pending, Reviewed, Interview, Rejected
        public string? EmployerNote { get; set; }
        public DateTime AppliedAt { get; set; } = DateTime.Now;
    }
}