using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paskaita_3_EntityFramework
{
    public class Projektas
    {
        public Projektas()
        {
            Darbuotojai = new List<Darbuotojas>();
        }

        public Projektas(string pavadinimas, DateTime pradzia, int trukme) : this()
        {
            Pavadinimas = pavadinimas;
            Pradzia = pradzia;
            Trukme = trukme;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjektoId { get; set; } // primary key, int
        [Required]
        public string Pavadinimas { get; set; } // nvchar(max)
        public DateTime Pradzia { get; set; } // datetime
        public int Trukme { get; set; } // int

        // Navigation property to Darbuotojas
        public ICollection<Darbuotojas> Darbuotojai { get; set; }
    }
}

