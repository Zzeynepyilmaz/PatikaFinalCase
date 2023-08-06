using System.Linq.Expressions;

namespace ApartmentManagementSystem.Repository
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        void Add(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
        Entity GetById(int id);
        IEnumerable<Entity> GetAll();
        List<Entity> GetAllWithInclude(params string[] includes);
        IEnumerable<Entity> Where(Expression<Func<Entity, bool>> expression);
        IEnumerable<Entity> WhereWithInclude(Expression<Func<Entity, bool>> expression, params string[] includes);
        IQueryable<Entity> GetAllAsQueryable();
    }
}
