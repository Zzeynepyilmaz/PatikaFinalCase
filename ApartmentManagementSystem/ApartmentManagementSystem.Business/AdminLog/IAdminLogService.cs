using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Business.Generic;
using ApartmentManagementSystem.ApartmentManagementSystem.Core.Dtos;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Business.AdminLog
{
    public interface IAdminLogService : IGenericService<AdminLoginDto, AdminLogRequest, AdminLogResponse>
    {
        ApiResponse<List<AdminLogResponse>> GetByAdminSession(string name);
    }
}
