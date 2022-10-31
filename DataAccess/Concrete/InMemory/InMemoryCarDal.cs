using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 350, ModelYear = 2016, Description = "Skoda SuperB" },
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 420, ModelYear = 2018, Description = "Volkswagen Passat" },
                new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 450, ModelYear = 2020, Description = "Volkswagen Golf" },
                new Car{Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 320, ModelYear = 2017, Description = "Fiat Egea" },
                new Car{Id = 5, BrandId = 1, ColorId = 2, DailyPrice = 330, ModelYear = 2016, Description = "Skoda Octavia" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
