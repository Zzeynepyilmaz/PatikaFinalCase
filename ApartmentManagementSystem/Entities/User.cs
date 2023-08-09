using System.ComponentModel.DataAnnotations.Schema;

namespace ApartmentManagementSystem.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TcNo { get; set; }
        public string PhoneNumber { get; set; } 
        public string isCar { get; set; }
        public string Role { get; set; }
    }
}
