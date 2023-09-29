using Microsoft.EntityFrameworkCore;
using PatientService.Data;
using PatientService.Models;

namespace PatientService.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Patient>> AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return await _context.Patients.ToListAsync();
        }

        public async Task<List<Patient>?> DeletePatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return null;
            }
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return await _context.Patients.ToListAsync();
        }

        public async Task<List<Patient>?> GetAllPatients()
        {
            var patients = await _context.Patients.ToListAsync();
            if (patients == null)
            {
                return null;
            }
            return patients;
        }

        public async Task<Patient?> GetPatientById(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return null;
            }
            return patient;
        }

        public async Task<List<Patient>?> UpdatePatient(int id, Patient request)
        {
            var patient = await _context.Patients.FindAsync(id);
            if(patient == null)
            {
                return null;
            }
            patient.FirstName = request.FirstName;
            patient.LastName = request.LastName;
            patient.Gender = request.Gender;
            patient.BirthDate = request.BirthDate;
            patient.ProfileIsActive = request.ProfileIsActive;

            await _context.SaveChangesAsync();

            return await _context.Patients.ToListAsync();
        }
    }
}
