using Cars.WebAPI.Data;
using Cars.WebAPI.Entities;
using Cars.WebAPI.Repositories.Base;

namespace Cars.WebAPI.Repositories
{
    public class CarRepository : BaseRepository<CarEntity>
    {
        public CarRepository(ApplicationDbContext context) : base(context) { }

        public override void Create(CarEntity entity)
        {
            _context.Cars.Add(entity);
            _context.SaveChanges();
        }

        public override void Delete(int id)
        {
            var car = _context.Cars.FirstOrDefault(car => car.Id.Equals(id));
            _context.Remove(car);
            _context.SaveChanges();
        }

        public override void Update(CarEntity entity)
        {
            _context.Cars.Update(entity);
            _context.SaveChanges();
        }
        public override IEnumerable<CarEntity> GetAll() => _context.Cars.ToList();

        public override CarEntity GetById(int id) => _context.Cars.FirstOrDefault(car => car.Id.Equals(id));
    }
}
