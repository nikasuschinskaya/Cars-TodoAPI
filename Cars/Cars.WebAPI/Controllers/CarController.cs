using Cars.WebAPI.Entities;
using Cars.WebAPI.Models;
using Cars.WebAPI.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace Cars.WebAPI.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : ControllerBase
    {
        private readonly IRepository<CarEntity> _carRepository;

        public CarController(IRepository<CarEntity> carRepository) => _carRepository = carRepository;

        [HttpGet]
        public IActionResult Get()
        {
            var cars = _carRepository.GetAll();
            return Ok(cars);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            var newCar = new CarEntity
            {
                Id = car.CarId,
                Brand = car.Brand,
                Power = car.Power,
                Price = car.Price,
                Color = car.Color
            };
            _carRepository.Create(newCar);
            return Ok(car);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Car car)
        {
            var existingCar = _carRepository.GetById(id);
            if (existingCar == null)
            {
                return NotFound();
            }
            existingCar.Brand = car.Brand;
            existingCar.Power = car.Power;
            existingCar.Price = car.Price;
            existingCar.Color = car.Color;
            _carRepository.Update(existingCar);
            return Ok(existingCar);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var car = _carRepository.GetById(id);
            if (car == null)
            {
                return NotFound();
            }
            _carRepository.Delete(id);
            return Ok(car);
        }

    }
}
