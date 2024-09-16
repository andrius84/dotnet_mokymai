namespace Uzduotis_10.Entities
{
    public class Gydytojas
    {
        public int Id { get; set; }
        public string Vardas { get; set; } 
        public string Pavarde { get; set; }
        //public int SpecializacijaId { get; set; }

        public ICollection<Pacientas> Pacientai { get; set; }
        public ICollection<Vizitas> Vizitai { get; set; }
        public Specializacija Specializacija { get; set; }
    }
}
