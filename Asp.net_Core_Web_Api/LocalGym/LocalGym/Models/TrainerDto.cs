namespace LocalGym.Models
{/// <summary>
/// trainer dto
/// </summary>
    public class TrainerDto
    {   /// <summary>
    /// 
    /// trainer id
    /// </summary>
        public int TrainerId { get; set; }

        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Speciality { get; set; }
        public double? FeePer30Minutes { get; set; }

        public DateTime? HireDate { get; set; }
    }
}
