using System.ComponentModel.DataAnnotations.Schema;

namespace ApartmentManagementSystem.Entities
{
    public class Admin : User
    {
       public int AdminId { get; set; }
    }
}
