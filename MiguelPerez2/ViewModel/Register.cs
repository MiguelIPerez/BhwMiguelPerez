using System.ComponentModel.DataAnnotations;

namespace MiguelPerez2.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Confirm mail should be same as Password")]
        public string ConfirmPassword { get; set; }
    }
}
