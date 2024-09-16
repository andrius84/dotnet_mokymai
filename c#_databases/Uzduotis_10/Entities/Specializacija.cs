namespace Uzduotis_10.Entities
{
    public class Specializacija
    {
        public int Id { get; set; }
        public string SpecializacijosPavadinimas { get; set; }
        public int GydytojasId { get; set; }

        public Gydytojas Gydytojas { get; set; }
    }
}
