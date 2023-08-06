using ApartmentManagementSystem.MsDbContext;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApartmentManagementSystem.Repository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private readonly ManagementSystemDbContext msDbContext;
        public GenericRepository(ManagementSystemDbContext msDbContext)
        {
            this.msDbContext = msDbContext;
        }
        public void Add(Entity entity)
        {
            msDbContext.Set<Entity>().Add(entity);
        }

        public void Delete(Entity entity)
        {
            msDbContext.Set<Entity>().Remove(entity);
        }

        public IEnumerable<Entity> GetAll()
        {
            return msDbContext.Set<Entity>().AsNoTracking().ToList();
        }

        public IQueryable<Entity> GetAllAsQueryable()
        {
            return msDbContext.Set<Entity>().AsQueryable();
        }

        public List<Entity> GetAllWithInclude(params string[] includes)
        {
            throw new NotImplementedException();
        }

        public Entity GetById(int id)
        {
            var entity = msDbContext.Set<Entity>().Find(id);
            return entity;
        }

        public void Update(Entity entity)
        {
            msDbContext.Set<Entity>().Update(entity);
        }

        public IEnumerable<Entity> Where(Expression<Func<Entity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> WhereWithInclude(Expression<Func<Entity, bool>> expression, params string[] includes)
        {
            throw new NotImplementedException();
        }
    }
}
