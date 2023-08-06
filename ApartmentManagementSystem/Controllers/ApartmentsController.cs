using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.Controllers
{
    public class ApartmentsController : ControllerBase
    {
        private readonly ManagementSystemDbContext _context;
        private readonly IMapper _mapper;

        public ApartmentsController(ManagementSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
    public ActionResult<IEnumerable<Apartment>> GetApartments()
        {
            // Daire/konut bilgilerini veritabanından çekerek döndür
        }

        // Daire/konut bilgisi ekle
        [HttpPost]
        public ActionResult AddApartment(Apartment apartment)
        {
            // Veritabanına yeni daire/konut bilgisini ekle
        }

        // Daire/konut bilgisini güncelle
        [HttpPut("{id}")]
        public ActionResult UpdateApartment(int id, Apartment apartment)
        {
            // Veritabanında ilgili daire/konut bilgisini güncelle
        }

        // Daire/konut bilgisini sil
        [HttpDelete("{id}")]
        public ActionResult DeleteApartment(int id)
        {
            // Veritabanından ilgili daire/konut bilgisini sil
        }
    }
}
