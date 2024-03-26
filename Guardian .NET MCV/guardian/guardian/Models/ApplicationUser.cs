using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace guardian.Models
{
    public class ApplicationUser : IdentityUser
    {    
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Nickname must be between 3 and 16 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Username can only contain letters")]
        public string? Nickname { get; set; }

        public DateTime Join_Date { get; set; } = DateTime.Now;
    }
}
