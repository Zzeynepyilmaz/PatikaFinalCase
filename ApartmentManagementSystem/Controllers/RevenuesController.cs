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
    public class RevenuesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ManagementSystemDbContext context;
        private readonly IMapper mapper;

        public RevenuesController(ManagementSystemDbContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            context = context;
            mapper = mapper;
            unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ApiResponse<List<Revenue>> GetAll()
        {
            var revenueList = unitOfWork.RevenueRepository.GetAll();
            var mapped = mapper.Map<List<Revenue>, List<Revenue>>(revenueList);
            return new ApiResponse<List<Revenue>>(mapped);
        }

        [HttpGet("{id}")]
        public ApiResponse<Revenue> GetById(int id)
        {
            var revenue = unitOfWork.RevenueRepository.GetById(id);
            var mapped = mapper.Map<Revenue>(revenue);
            return new ApiResponse<Revenue>(mapped);
        }

        [HttpPost]
        public ApiResponse AddRevenue([FromBody] Revenue revenue)
        {
            unitOfWork.RevenueRepository.Insert(revenue);
            unitOfWork.RevenueRepository.Save();
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse UpdateRevenue(int id, [FromBody] Revenue revenue)
        {

            unitOfWork.RevenueRepository.Insert(revenue);
            revenue.RevenueId = id;

            unitOfWork.RevenueRepository.Update(revenue);
            unitOfWork.RevenueRepository.Save();
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse DeleteRevenue(int id)
        {
            unitOfWork.RevenueRepository.DeleteById(id);
            unitOfWork.RevenueRepository.Save();
            return new ApiResponse();
        }

    }
}
