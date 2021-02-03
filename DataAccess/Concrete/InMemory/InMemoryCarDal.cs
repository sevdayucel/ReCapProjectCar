using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _car;
        
        public InMemoryCarDal()
        {
            _car = new List<Car> ()
            {
                new Car{ Id=1, BrandId=1, ColorId=121, ModelYear=1903,DailyPrice=140,Description="Mini Cooper" },
                new Car{ Id=2, BrandId=1, ColorId=182, ModelYear=2020,DailyPrice=160,Description="Range Rover" },
                new Car{ Id=3, BrandId=2, ColorId=132, ModelYear=2003,DailyPrice=150,Description="Mercedes" },
                new Car{ Id=4, BrandId=2, ColorId=125, ModelYear=1997,DailyPrice=105,Description="Kia" },
                new Car{ Id=5, BrandId=2, ColorId=128, ModelYear=1998,DailyPrice=155,Description="BMW" }


            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {


            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByBrandId (int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColor (int colorId)
        {
            return _car.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetByDailyPrice (int dailyPrice)
        {
            return _car.Where(c => c.DailyPrice == dailyPrice).ToList();
        }

        public List<Car>GetById (int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<Car>GetByModelYear(int modelYear)
        {
            return _car.Where(c => c.ModelYear == modelYear).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        
    }
}
