using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Business.Generic;
using ApartmentManagementSystem.ApartmentManagementSystem.Core.Dtos;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using AutoMapper;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Business.AdminLog
{
    public class AdminLogService : GenericService<AdminLoginDto, AdminLogRequest, AdminLogResponse>, IAdminLogService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public AdminLogService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public ApiResponse<List<AdminLogResponse>> GetByAdminSession(string name)
        {
            var list = unitOfWork.AdminLoginDtoRepository.Where(x => x.UserName == name).ToList();
            var mapped = mapper.Map<List<AdminLogResponse>>(list);
            return new ApiResponse<List<AdminLogResponse>>(mapped);
        }
    }
}
