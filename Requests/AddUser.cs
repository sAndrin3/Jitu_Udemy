using System.ComponentModel.DataAnnotations;

namespace Jitu_Udemy.Requests{
    public class AddUser
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; } = string.Empty;
    }
}