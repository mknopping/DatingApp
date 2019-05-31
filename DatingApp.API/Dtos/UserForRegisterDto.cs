using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Your password must be between 4 and 25 characters")]
        public string Password { get; set; }
    }
}