using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
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
        private readonly IUnitOfWork unitOfWork;
        private readonly ManagementSystemDbContext context;
        private readonly IMapper mapper;

        public UsersController(ManagementSystemDbContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            context = context;
            mapper = mapper;
            unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ApiResponse<List<User>> GetAll()
        {
            var userList = unitOfWork.UserRepository.GetAll();
            var mapped = mapper.Map<List<User>, List<User>>(userList);
            return new ApiResponse<List<User>>(mapped);
        }

        [HttpGet("{id}")]
        public ApiResponse<User> GetById(int id)
        {
            var user = unitOfWork.UserRepository.GetById(id);
            var mapped = mapper.Map<User>(user);
            return new ApiResponse<User>(mapped);
        }

        [HttpPost]
        public ApiResponse AddUser([FromBody] User user)
        {
            unitOfWork.UserRepository.Insert(user);
            unitOfWork.UserRepository.Save();
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse UpdateUser(int id, [FromBody] User user)
        {

            unitOfWork.UserRepository.Insert(user);
            user.UserId = id;

            unitOfWork.UserRepository.Update(user);
            unitOfWork.UserRepository.Save();
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse DeleteUser(int id)
        {
            unitOfWork.UserRepository.DeleteById(id);
            unitOfWork.UserRepository.Save();
            return new ApiResponse();
        }



    }
}
