using Uzduotis_10.Repositories;
using Uzduotis_10.Entities;


namespace Uzduotis_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var context = new HospitalContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var patientRepository = new PatientRepository(context);

            var patient = new Pacientas
            {
                Vardas = "John",
                Pavarde = "Doe",
                GimimoData = new DateTime(1990, 1, 1)
            };

            var patientId = patientRepository.AddPatient(patient);

            Console.WriteLine($"Added patient with id: {patientId}");

        }
    }
}
