using System.ComponentModel.DataAnnotations;

namespace DOTNET_PROJECT.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
    
        [Required]
        public string UserId { get; set; }

        public string Email { get; set; }
    
        public string FullName { get; set; }
    
        public string Address { get; set; }
    
        // Other properties such as phone number, profile picture URL, etc.
    }

}