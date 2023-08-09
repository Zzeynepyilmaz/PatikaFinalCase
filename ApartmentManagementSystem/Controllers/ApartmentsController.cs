using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApartmentManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApartmentsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ManagementSystemDbContext context;
        private readonly IMapper _mapper;

        public ApartmentsController(ManagementSystemDbContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            context = context;
            mapper = mapper;
            unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ApiResponse<List<Apartment>> GetAll()
        {
            var apartmentList = unitOfWork.ApartmentRepository.GetAll();
            var mapped = _mapper.Map<List<Apartment>, List<Apartment>>(apartmentList);
            return new ApiResponse<List<Apartment>>(mapped);
        }

        [HttpGet("{id}")]
        public ApiResponse<Apartment> GetById(int id)
        {
            var apartment = unitOfWork.ApartmentRepository.GetById(id);
            var mapped = _mapper.Map<Apartment>(apartment);
            return new ApiResponse<Apartment>(mapped);
        }

        [HttpPost]
        public ApiResponse AddApartment([FromBody] Apartment apartment)
        {
            unitOfWork.ApartmentRepository.Insert(apartment);
            unitOfWork.ApartmentRepository.Save();
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse UpdateApartment(int id, [FromBody] Apartment apartment)
        {
            
            unitOfWork.ApartmentRepository.Insert(apartment);
            apartment.ApartmentId = id;

            unitOfWork.ApartmentRepository.Update(apartment);
            unitOfWork.ApartmentRepository.Save();
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse DeleteApartment(int id)
        {
            unitOfWork.ApartmentRepository.DeleteById(id);
            unitOfWork.ApartmentRepository.Save();
            return new ApiResponse();
        }

        //Crud updated
    }
}
