using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using ApartmentManagementSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ManagementSystemDbContext msDbContext;
        public UnitOfWork(ManagementSystemDbContext msDbContext)
        {
            this.msDbContext = msDbContext;

            AdminRepository = new GenericRepository<Admin>(msDbContext);
            UserRepository = new GenericRepository<User>(msDbContext);
            ApartmentRepository = new GenericRepository<Apartment>(msDbContext);
            BillRepository = new GenericRepository<Bill>(msDbContext);
            MessageRepository = new GenericRepository<Message>(msDbContext);
            RevenueRepository = new GenericRepository<Revenue>(msDbContext);
        }
        public IGenericRepository<Admin> AdminRepository { get; private set; }

        public IGenericRepository<User> UserRepository { get; private set; }

        public IGenericRepository<Apartment> ApartmentRepository { get; private set; }

        public IGenericRepository<Bill> BillRepository { get; private set; }

        public IGenericRepository<Message> MessageRepository { get; private set; }

        public IGenericRepository<Revenue> RevenueRepository { get; private set; }

        public IGenericRepository<Entity> DynamicRepository<Entity>() where Entity : class
        {
            return new GenericRepository<Entity>(msDbContext);
        }
    }
}
