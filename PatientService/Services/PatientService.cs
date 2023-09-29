using PatientService.Models;
using PatientService.Repositories;

namespace PatientService.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Patient>> AddPatient(Patient patient)
        {
            return await _repository.AddPatient(patient);
        }

        public async Task<List<Patient>?> DeletePatient(int id)
        {
            return await _repository.DeletePatient(id);
        }

        public async Task<List<Patient>?> GetAllPatients()
        {
            return await _repository.GetAllPatients();
        }

        public async Task<Patient?> GetPatientById(int id)
        {
            return await _repository.GetPatientById(id);
        }

        public async Task<List<Patient>?> UpdatePatient(int id, Patient request)
        {
            return await _repository.UpdatePatient(id, request);
        }
    }
}
