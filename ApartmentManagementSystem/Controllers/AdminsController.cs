using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ManagementSystemDbContext context;
        private readonly IMapper mapper;

        public AdminsController(ManagementSystemDbContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            context = context;
            mapper = mapper;
            unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ApiResponse<List<Admin>> GetAll()
        {
            var adminList = unitOfWork.AdminRepository.GetAll();
            var mapped = mapper.Map<List<Admin>, List<Admin>>(adminList);
            return new ApiResponse<List<Admin>>(mapped);
        }

        [HttpGet("{id}")]
        public ApiResponse<Admin> GetById(int id)
        {
            var admin = unitOfWork.AdminRepository.GetById(id);
            var mapped = mapper.Map<Admin>(admin);
            return new ApiResponse<Admin>(mapped);
        }

        [HttpPost]
        public ApiResponse AddAdmin([FromBody] Admin admin)
        {
            unitOfWork.AdminRepository.Insert(admin);
            unitOfWork.AdminRepository.Save();
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse UpdateAdmin(int id, [FromBody] Admin admin)
        {

            unitOfWork.AdminRepository.Insert(admin);
            admin.AdminId = id;

            unitOfWork.AdminRepository.Update(admin);
            unitOfWork.AdminRepository.Save();
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse DeleteAdmin(int id)
        {
            unitOfWork.AdminRepository.DeleteById(id);
            unitOfWork.AdminRepository.Save();
            return new ApiResponse();
        }

    }
}