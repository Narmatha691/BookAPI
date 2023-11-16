using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(50)]
        [Required]
        public string? BookName { get; set; }
        [Required]
        public double? Price { get; set; }
        [StringLength(50)]
        public string? Author { get; set; }
        [StringLength(50)]
        public string? Language { get; set; }
        [Column("ReleaseDate", TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }

    }
}
