using System.ComponentModel.DataAnnotations;

namespace LocalGym.Entities
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
       
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        [EmailAddress]
       
        public required string Email { get; set; }

        public DateTime JoinDate { get; set; }
        public IEnumerable<Session> Sessions { get; set; } = new List<Session>();
    }
}
