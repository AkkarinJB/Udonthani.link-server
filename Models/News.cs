using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udonthani_link_api.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public User? Author { get; set; }
    }
}