using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels
{
    public class CrtUserVM
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = null!;

        public string? Address { get; set; }

    }
}
