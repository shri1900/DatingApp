using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=4,ErrorMessage="Password length must be min 4 and max 8")]
        public string Password { get; set; }
    }
}