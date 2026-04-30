using System.ComponentModel.DataAnnotations;

namespace udonthani_link_api.Models
{
    public class JobCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}