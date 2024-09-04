using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8_ManyToMany.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public required string Name { get; set; }
        public int Year { get; set; }   
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
