namespace LocalGym.Models
{
    public class TrainerDto
    {
        public int TrainerId { get; set; }

        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Speciality { get; set; }
        public double? FeePer30Minutes { get; set; }

        public DateTime? HireDate { get; set; }
    }
}
