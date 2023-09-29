namespace PatientService.Models
{
    public class Patient
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender {  get; set; } = string.Empty;
        public DateOnly Birthdate { get; set; }
        public bool ProfileIsActive { get; set; }

        public Patient(int id, string firstName, string lastName, string gender, DateOnly birthdate, bool profileIsActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthdate = birthdate;
            ProfileIsActive = profileIsActive;
        }

    }
}
