using System.ComponentModel.DataAnnotations;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Core.Dtos
{
    public class AdminLoginDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; init; }
    }
}
