using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paskaita_3_EntityFramework
{
    public class Skyrius
    {
        public Skyrius()
        {
            Darbuotojai = new List<Darbuotojas>();
            Projektai = new List<Projektas>();
        }

        public Skyrius(string pavadinimas) : this()
        {
            Pavadinimas = pavadinimas;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SkyriusId { get; set; } // primary key, int
        [Required]
        public string Pavadinimas { get; set; } // nvchar(max)
        public string VadovoAsmensKodas { get; set; } // nvchar(max)

        // Navigacines savybes
        public ICollection<Darbuotojas> Darbuotojai { get; set; }
        public ICollection<Projektas> Projektai { get; set; }
    }
}

