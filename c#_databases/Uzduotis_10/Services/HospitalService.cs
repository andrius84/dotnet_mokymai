using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_10.Repositories;

namespace Uzduotis_10.Services
{
    public class HospitalService
    {
        private readonly VizitaiRepository _appointmentRepository;

        public HospitalService(VizitaiRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public bool SetMaxAppointmentsForDoctorsPerDay(int doctorId, int maxAppointments, DateTime appointmentDate)
        {
            var appointmentsOnDay = _appointmentRepository
                .GetAppointmentsByDoctorId(doctorId)
                .Where(a => a.VizitoData.Date == appointmentDate.Date)
                .Count();

            if (appointmentsOnDay >= maxAppointments)
            {
                return false; 
            }
            return true; 
        }

        public bool IsThereAppointmentForSameDoctorOnTheSameHour(int doctorId, DateTime appointmentTime)
        {
            var isTimeOccupied = _appointmentRepository
                .GetAppointmentsByDoctorId(doctorId)
                .Any(a => a.VizitoData == appointmentTime);

            return isTimeOccupied; 
        }
    }
}
