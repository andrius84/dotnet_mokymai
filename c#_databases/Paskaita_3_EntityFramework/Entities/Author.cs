using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paskaita_3_EntityFramework.Entities
{
    [Table("Authors")]
    public class Author
    {
        public Author()
        {
        }

        public Author(int bookId, string fullName)
        {
            BookId = bookId;
            FullName = fullName;
        }

        [Key] // nustatomas pirminis raktas (Primary Key)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // nustatomas autoincrement
        public int AuthorId { get; set; }

        [ForeignKey(nameof(Book))] // nurodoma, kad sio lauko reiksme yra kitos lenteles pirminis raktas
        public int BookId { get; set; }

        [Required]
        public required string FullName { get; set; }
        
        public Book Book { get; set; } // navigacine savybe

    }
}