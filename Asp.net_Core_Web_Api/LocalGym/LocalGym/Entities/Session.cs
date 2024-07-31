using Microsoft.AspNetCore.Identity.UI.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalGym.Entities
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Member Member { get; set; }


        [Required]
        public int TrainerId { get; set; }

        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }

        public DateTime SessionDate { get; set; }

        public string? Duration { get; set; }

       // public IEnumerable<Member> Members { get; set; }=new List<Member>();
      
    }
}
