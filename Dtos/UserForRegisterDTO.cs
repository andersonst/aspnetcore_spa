using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8 , MinimumLength = 4, ErrorMessage = "A senha deverá conter entre 4 a 8 caracteres")]
        public string Password { get; set; }
    }
}