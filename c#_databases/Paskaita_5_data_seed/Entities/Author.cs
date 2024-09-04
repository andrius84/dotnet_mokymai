using System.Diagnostics.Metrics;

namespace Paskaita_5_data_seed.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public required string FullName { get; set; }
        public int BookId { get; set; }
        public int CountryId { get; set; }
        public Book Book { get; set; }
        public Country Country { get; set; }
    }
}

