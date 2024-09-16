using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_10.Entities;

namespace Uzduotis_10.Repositories
{
    public class PatientRepository
    {
        private readonly HospitalContext _context;

        public PatientRepository(HospitalContext context)
        {
            _context = context;
        }

        public int AddPatient(Pacientas patient)
        {
            if (patient.Vardas == null || patient.Pavarde == null || patient.GimimoData == null)
            {
                return 0;
            }

            _context.Pacientai.Add(patient);
            _context.SaveChanges(); 
            return patient.Id;
        }

        public Pacientas GetPatientById(int id)
        {
            return _context.Pacientai.Find(id);
        }

        public List<Vizitas> GetAppointmentsByPatientId(int id)
        {
            return _context.Pacientai
                .Where(p => p.Id == id)
                .SelectMany(p => p.Vizitai)
                .ToList(); 
        }

        public void UpdatePatient(Pacientas patient)
        {
            _context.Pacientai.Update(patient); 
            _context.SaveChanges();
        }

        public List<Pacientas> GetAllPatients()
        {
            return _context.Pacientai.ToList();
        }
    }
}
