namespace PatientService.Models
{
    public class Patient
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }//Change format to only date
        public bool ProfileIsActive { get; set; }
        
    }
}
