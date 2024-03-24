using System.ComponentModel.DataAnnotations;

namespace guardian.Models
{
    public class Account
    {
        /* Primary Info **************/
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 16 characters")]
        [RegularExpression(@"^[a-zA-Z0-9_\s]+$", ErrorMessage = "Username can only contain letters, numbers, and underscores")]
        public string Username { get; set; }

        [StringLength(16, MinimumLength = 3, ErrorMessage = "Nickname must be between 3 and 16 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Username can only contain letters")]
        public string ?Nickname { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters")]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*\W).{6,}$", ErrorMessage = "Password must contain at least one number, an uppercase letter, and a special character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 chatacters")]
        public string Email { get; set; }

        public DateTime Join_Date { get; set; } = DateTime.Now;
    }

    public enum Gender
    {
        male,
        female
    }

    public enum Rank
    {
        Legionnaire
    }
}