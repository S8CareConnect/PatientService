using Microsoft.AspNetCore.Mvc;
using PatientService.Models;
using PatientService.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Patient>>> GetAllPatients()
        {
            var result = await _patientService.GetAllPatients();
            if (result == null)
            {
                return NotFound("No Patients found");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatientById(int id)
        {
            var result = await _patientService.GetPatientById(id);
            if (result == null)
            {
                return NotFound("Patient not found by given id: " + id);
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Patient>>> AddPatient(Patient patient)
        {
            var result = await _patientService.AddPatient(patient);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Patient>>> UpdatePatient(int id, Patient request)
        {
            var result = await _patientService.UpdatePatient(id, request);
            if (result == null)
            {
                return NotFound("Patient not found by given id: " + id);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Patient>>> DeletePatient(int id)
        {
            var result = await _patientService.DeletePatient(id);
            if (result == null)
            {
                return NotFound("Patient not found by given id: " + id);
            }
            return Ok(result);
        }
    }
}
