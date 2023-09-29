using PatientService.Models;

namespace PatientService.Service
{
    public interface IPatientService
    {
        Task<List<Patient>?> GetAllPatients();
        Task<Patient?> GetPatientById(int id);
        Task<List<Patient>> AddPatient(Patient patient);
        Task<List<Patient>?> UpdatePatient(int id, Patient request);
        Task<List<Patient>?> DeletePatient(int id);
    }
}
