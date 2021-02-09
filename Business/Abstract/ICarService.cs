using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetByDailyPrice(decimal max,decimal min);
        List<Car> GetByModelYear(string year);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
