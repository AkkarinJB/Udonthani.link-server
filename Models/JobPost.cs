using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udonthani_link_api.Models
{
    public class JobPost
    {
        [Key]
        public int Id { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company? Company { get; set; }

        public int JobCategoryId { get; set; }
        [ForeignKey("JobCategoryId")]
        public JobCategory? JobCategory { get; set; }

        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")]
        public JobType? JobType { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }

        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Requirements { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public bool IsHideSalary { get; set; } = false;
        public int ViewCount { get; set; } = 0;
        
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // 1 ประกาศงาน มีคนมาสมัครได้หลายคน
        public ICollection<Application>? Applications { get; set; }
    }
}