using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow
{
    public interface IUnitOfWork
    {
        IGenericRepository<Entity> DynamicRepository<Entity>() where Entity : class;
        IGenericRepository<Admin> AdminRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Apartment> ApartmentRepository { get; }
        IGenericRepository<Bill> BillRepository { get; }
        IGenericRepository<Message> MessageRepository { get; }
        IGenericRepository<Revenue> RevenueRepository { get; }
    }
}
