using Cars.WebAPI.Data;

namespace Cars.WebAPI.Repositories.Base
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        protected readonly ApplicationDbContext _context;
        protected BaseRepository(ApplicationDbContext context) => _context = context;

        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(int id);
        public abstract T GetById(int id);
        public abstract IEnumerable<T> GetAll();
    }
}
