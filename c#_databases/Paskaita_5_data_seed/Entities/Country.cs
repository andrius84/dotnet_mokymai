using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5_data_seed.Entities
{
    public class Country  //uzduotis
    {
        [Key]
        public int CountryId { get; set; }
        public required string Name { get; set; }

        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
