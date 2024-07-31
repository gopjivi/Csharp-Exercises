using System.ComponentModel.DataAnnotations;

namespace LocalGym.Models
{
    public class MemberDto
    {
        public int MemberId { get; set; }

        public required string FirstName { get; set; }
        public string? LastName { get; set; }
       

        public required string Email { get; set; }

        public DateTime JoinDate { get; set; }
    }
}
