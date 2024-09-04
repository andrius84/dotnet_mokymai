using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paskaita_3_EntityFramework
{
    public class Darbuotojas
    {
        public Darbuotojas()
        {
        }

        public Darbuotojas(string asmensKodas, string vardas, string pavarde, DateTime dirbaNuo, int gimimoMetai, string pareigos, int skyriusId, int? projektasId)
        {
            AsmensKodas = asmensKodas;
            Vardas = vardas;
            Pavarde = pavarde;
            DirbaNuo = dirbaNuo;
            GimimoMetai = gimimoMetai;
            Pareigos = pareigos;
            SkyriusId = skyriusId;
            ProjektasId = projektasId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DarbuotojasId { get; set; } // primary key, int
        [Required]
        public string AsmensKodas { get; set; } // nvchar(max)
        [Required]
        public string Vardas { get; set; } // nvchar(max)
        [Required]
        public string Pavarde { get; set; } // nvchar(max)
        [Required]
        public DateTime DirbaNuo { get; set; } // datetime
        public int GimimoMetai { get; set; } // int
        public string Pareigos { get; set; } // nvchar(max)

        [ForeignKey(nameof(Skyrius))]
        public int SkyriusId { get; set; } // int

        [ForeignKey(nameof(Projektas))]
        public int? ProjektasId { get; set; } // int

        // Navigacines savybes
        public Skyrius Skyrius { get; set; }
        public Projektas Projektas { get; set; }
    }
}

