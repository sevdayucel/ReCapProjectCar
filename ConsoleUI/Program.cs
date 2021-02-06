using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Repository;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);

            }
            carManager.Add(new Car { BrandId = 3, ColorId = 8, DailyPrice = 200, ModelYear = 1903, Description = " Kia" });
            brandManager.Add(new Brand { BrandName = "i" });
        }
    }
}
