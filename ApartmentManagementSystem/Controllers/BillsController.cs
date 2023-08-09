using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApartmentManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ManagementSystemDbContext context;
        private readonly IMapper mapper;

        public BillsController(ManagementSystemDbContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            context = context;
            mapper = mapper;
            unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ApiResponse<List<Bill>> GetAll()
        {
            var billList = unitOfWork.BillRepository.GetAll();
            var mapped = mapper.Map<List<Bill>, List<Bill>>(billList);
            return new ApiResponse<List<Bill>>(mapped);
        }

        [HttpGet("{id}")]
        public ApiResponse<Bill> GetById(int id)
        {
            var bill = unitOfWork.BillRepository.GetById(id);
            var mapped = mapper.Map<Bill>(bill);
            return new ApiResponse<Bill>(mapped);
        }

        [HttpPost]
        public ApiResponse AddBill([FromBody] Bill bill)
        {
            unitOfWork.BillRepository.Insert(bill);
            unitOfWork.BillRepository.Save();
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse UpdateBill(int id, [FromBody] Bill bill)
        {

            unitOfWork.BillRepository.Insert(bill);
            bill.BillId = id;

            unitOfWork.BillRepository.Update(bill);
            unitOfWork.BillRepository.Save();
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse DeleteBill(int id)
        {
            unitOfWork.BillRepository.DeleteById(id);
            unitOfWork.BillRepository.Save();
            return new ApiResponse();
        }
    }

}
