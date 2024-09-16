namespace Uzduotis_10.Entities
{
    public class Diagnoze
    {
        public int Id { get; set; }
        public string DiagnozesPavadinimas { get; set; } 
        public string Aprasymas { get; set; } 

        public ICollection<Vizitas> Vizitai { get; set; } 
    }
}
