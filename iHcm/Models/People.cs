using System.ComponentModel.DataAnnotations;

namespace iHcm.Models
{
    public class People
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name  { get; set; }
        [Required]
        public string EmailId { get; set; } 

    }
}
