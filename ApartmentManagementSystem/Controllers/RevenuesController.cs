using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.Controllers
{
    public class RevenuesController : Controller
    {
        private readonly ManagementSystemDbContext _context;
        public RevenuesController(ManagementSystemDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Revenue>> GetMonthlyRevenues()
        {
            // Aylık borç-alacak listesini veritabanından çekerek döndür
        }
    }
}
