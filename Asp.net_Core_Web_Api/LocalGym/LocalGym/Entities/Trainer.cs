using System.ComponentModel.DataAnnotations;

namespace LocalGym.Entities
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
       
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Speciality { get; set; }
        public double? FeePer30Minutes { get; set; }

        public DateTime? HireDate { get; set; }

        public IEnumerable<Session> Sessions { get; set; } = new List<Session>();

    }
}
