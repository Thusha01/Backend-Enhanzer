using System.ComponentModel.DataAnnotations;

namespace Backend_Enhanzer.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); 

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty; 

        [Required]
        [MaxLength(50)]
        public string Author { get; set; } = string.Empty; 
        public string? ISBN { get; set; } 

        [Required]
        public DateTime PublicationDate { get; set; } 
    }
}
