using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();        
        List<Car> GetById(int Id);
        List<Car> GetByColor(int ColorId);
        List<Car> GetByBrandId(int BrandId );
        List<Car> GetByDailyPrice(int DailyPrice);
        List<Car> GetByModelYear(int ModelYear);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        
    }
}
