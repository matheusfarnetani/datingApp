using System.ComponentModel.DataAnnotations;

//DTO - Data Transfer Options

namespace DatingApp.Server.DTOs
{
    public class RegisterDto
    {
        [Required]
        [MaxLength(100)]
        public required string Username { get; set; }
        
        [Required]
        public required string Password { get; set; }
    }
}
