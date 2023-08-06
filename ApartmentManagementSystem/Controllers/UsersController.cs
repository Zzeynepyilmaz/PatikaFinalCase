using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using ApartmentManagementSystem.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApartmentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ManagementSystemDbContext _context;
        private readonly IMapper _mapper;

        public UsersController(ManagementSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost("User")]
        public IActionResult AddUser([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            // HTTP 201 Created döner ve eklenen nesneyi gösterir
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }

        [HttpGet("User/{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPut("User/{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.Find(id);

            if (user == null)
                return NotFound();

            // update database
            user.Name = updatedUser.Name;
            user.TcNo = updatedUser.TcNo;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("User/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }

        // Kullanıcı işlemleri
        // -------------------------------------------

        // Kullanıcı işlemleri de Admin işlemleri ile benzer şekilde implemente edilebilir
        // CRUD işlemleri için örnek metotlar oluşturulabilir

        // Fatura ödeme işlemi
        // -------------------------------------------


        [HttpGet("Bill/{id}")]
        public IActionResult GetBill(int id)
        {
            // Id'ye göre Bill'ı bul
            var bill = _context.Bills.Find(id);

            if (bill == null)
                return NotFound();

            return Ok(bill);
        }
        [HttpPost("PayBill")]
        public IActionResult PayBill([FromBody] Bill bill)
        {
            // Veritabanına ekle
            _context.Bills.Add(bill);
            _context.SaveChanges();

            // HTTP 201 Created döner ve eklenen nesneyi gösterir
            return CreatedAtAction(nameof(GetBill), new { id = bill.BillId }, bill);
        }


    }   
}
