using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Paskaita_5_data_seed.Entities

{
    public class Book
    {
        public int BookId { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public int GenreId { get; set; }
        public int PublisherId { get; set; }
        public List<Author> Authors { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }
    }
}