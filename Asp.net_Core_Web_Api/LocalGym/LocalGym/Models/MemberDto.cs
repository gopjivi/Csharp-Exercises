using System.ComponentModel.DataAnnotations;

namespace LocalGym.Models
{
    /// <summary>
    /// Member
    /// </summary>
    public class MemberDto
    {   /// <summary>
    /// memeber id
    /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// first name
        /// </summary>
        public required string FirstName { get; set; }
        /// <summary>
        /// last name
        /// </summary>
        public string? LastName { get; set; }
       /// <summary>
       /// email
       /// </summary>

        public required string Email { get; set; }
        /// <summary>
        /// joindate 
        /// </summary>
        public DateTime JoinDate { get; set; }
    }
}
