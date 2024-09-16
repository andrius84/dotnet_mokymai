namespace Uzduotis_10.Entities
{
    public class Vizitas
    {
        public int Id { get; set; }
        public int PacientasId { get; set; } 
        public int GydytojasId { get; set; } 
        public DateTime VizitoData { get; set; } 
        public int DiagnozeId { get; set; } 

        public Pacientas Pacientas { get; set; }
        public Gydytojas Gydytojas { get; set; }
        public Diagnoze Diagnoze { get; set; }
    }
}
