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

        public void Delete(Entity entity)
        {
            msDbContext.Set<Entity>().Remove(entity);
        }

        public void DeleteById(int id)
        {
            var entity = msDbContext.Set<Entity>().Find(id);
            Delete(entity);
        }

        public List<Entity> GetAll()
        {
            return msDbContext.Set<Entity>().AsNoTracking().ToList();
        }

        public IQueryable<Entity> GetAllAsQueryable()
        {
            return msDbContext.Set<Entity>().AsQueryable();
        }

        public List<Entity> GetAllWithInclude(params string[] includes)
        {
            var query = msDbContext.Set<Entity>().AsQueryable();
            query = includes.Aggregate(query, (currenct, inc) => currenct.Include(inc));
            return query.ToList();
        }

        public Entity GetById(int id)
        {
            var entity = msDbContext.Set<Entity>().Find(id);
            return entity;
        }

        public Entity GetByIdWithInclude(int id, params string[] includes)
        {
            var query = msDbContext.Set<Entity>().AsQueryable();
            query = includes.Aggregate(query, (currenct, inc) => currenct.Include(inc));
            return query.FirstOrDefault();// todo
        }

        public void Insert(Entity entity)
        {
    
            var insertedEntity = msDbContext.Entry(entity);
            insertedEntity.State = EntityState.Added;
        }

        public void Save()
        {
            msDbContext.SaveChanges();
        }

        public void Update(Entity entity)
        {
            msDbContext.Set<Entity>().Update(entity);
        }

        public IEnumerable<Entity> Where(Expression<Func<Entity, bool>> expression)
        {
            return msDbContext.Set<Entity>().Where(expression).AsQueryable();
        }

        public IEnumerable<Entity> WhereWithInclude(Expression<Func<Entity, bool>> expression, params string[] includes)
        {
            var query = msDbContext.Set<Entity>().AsQueryable();
            query.Where(expression);
            query = includes.Aggregate(query, (currenct, inc) => currenct.Include(inc));
            return query.ToList();
        }
    }
}
