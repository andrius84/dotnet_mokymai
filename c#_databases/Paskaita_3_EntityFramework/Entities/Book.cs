using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paskaita_3_EntityFramework.Entities
{
    [Table("Books")]

    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        
        [Required]
        public string Title { get; set; }

        public int Pages { get; set; }

        public int? Year { get; set; } // ? (nurodo, kad laukas gali buti null
        
        [Column(TypeName = "decimal(18, 2)")] // nurodoma, kad laukas bus decimal su 18 skaitmenu ir 2 po kablelio
        
        public decimal? Price { get; set; }

        public ICollection<Author> Authors { get; set; } // navigacine savybe
    }
}