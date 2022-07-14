using System.ComponentModel.DataAnnotations;

namespace MiguelPerez2.ViewModel
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
