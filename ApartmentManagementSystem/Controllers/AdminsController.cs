using ApartmentManagementSystem.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.Controllers
{
    public class AdminsController : Controller
    {
        // Gelen ödeme bilgilerini görüntüle
        [HttpGet("payments")]
        public ActionResult<IEnumerable<User>> GetPayments()
        {
            // Gelen ödeme bilgilerini veritabanından çekerek döndür
        }

        // Gelen mesajları görüntüle
        [HttpGet("messages")]
        public ActionResult<IEnumerable<Message>> GetAdminMessages()
        {
            // Gelen mesajları veritabanından çekerek döndür
        }

        // Aylık borç-alacak listesini görüntüle
        [HttpGet("revenues")]
        public ActionResult<IEnumerable<Revenue>> GetMonthlyRevenues()
        {
            // Aylık borç-alacak listesini veritabanından çekerek döndür
        }

        // Kişileri listele
        [HttpGet("users")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            // Kişileri veritabanından çekerek döndür
        }

        // Daire/konut bilgilerini listele
        [HttpGet("apartments")]
        public ActionResult<IEnumerable<Apartment>> GetApartments()
        {
            // Daire/konut bilgilerini veritabanından çekerek döndür
        }

        // Fatura ödemeyen kişilere günlük mail jobu çalıştır
        [HttpPost("send_reminder_emails")]
        public ActionResult SendReminderEmails()
        {
            // Fatura ödemeyen kişilere günlük mail job
        }
    }
}