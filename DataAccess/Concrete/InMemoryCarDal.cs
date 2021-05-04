using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id=1, BrandId=1, ColorId=1, DailyPrice=2500, ModelYear=2015, Description="Audi a763"},
                new Car(){Id=2, BrandId=1, ColorId=1, DailyPrice=3000, ModelYear=2018, Description="Audi g3754"},
                new Car(){Id=3, BrandId=2, ColorId=2, DailyPrice=1500, ModelYear=2015, Description="Prado a743"},
                new Car(){Id=4, BrandId=2, ColorId=1, DailyPrice=3100, ModelYear=2019, Description="Prado c236"},
                new Car(){Id=5, BrandId=3, ColorId=3, DailyPrice=1800, ModelYear=2015, Description="BMW a384"},
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

        public Car GetById(int id)
        {
            if (_cars.Any(c => c.Id == id))
            {
                return _cars.SingleOrDefault(c => c.Id == id);
            }

            else
                throw new Exception();

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
