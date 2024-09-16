using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_10.Entities;

namespace Uzduotis_10.Repositories
{
    public class VizitaiRepository
    {
        private readonly HospitalContext _context;

        public VizitaiRepository(HospitalContext context)
        {
            _context = context;
        }

        public int AddAppointment(Vizitas appointment)
        {
            _context.Vizitai.Add(appointment);
            _context.SaveChanges(); 
            return appointment.Id;
        }

        public Vizitas GetAppointmentById(int id)
        {
            return _context.Vizitai.FirstOrDefault(v => v.Id == id); 
        }

        public List<Vizitas> GetAppointmentsByDoctorId(int doctorId)
        {
            return _context.Vizitai.Where(v => v.GydytojasId == doctorId).ToList(); 
        }
    }
}
