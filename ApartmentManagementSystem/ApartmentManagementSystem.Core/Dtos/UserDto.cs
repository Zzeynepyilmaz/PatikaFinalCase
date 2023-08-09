using System.ComponentModel.DataAnnotations;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Core.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "TcNo is required")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Car info is required")]
        public string isCar { get; set; }
        public string Role { get; set; }
    }
}
