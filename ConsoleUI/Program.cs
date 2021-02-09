using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
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


            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandId + "/" + car.ColorName + " / " + car.Description + " / " + car.DailyPrice);

            }

        }
        public static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            
            colorManager.Delete(new Color { ColorId = 3 , ColorName = " Mor " });
        }

        public static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand{ BrandId = 2, BrandName = " Güncellendi " });
        }

        public static void CarTest()
        {
            CarManager carManager = new  CarManager(new  EfCarDal());
            
            carManager.Update(new  Car { CarId = 2 , BrandId = 2 , ColorId = 3 , DailyPrice = 150 , ModelYear = 2020, Descriptions = " Kia Otomatik Vites" });
            carManager.Delete(new  Car { CarId = 1 , BrandId = 3 , ColorId = 1 , DailyPrice = 100 , ModelYear = 1903, Descriptions = " MiniCooper Elektrikli" });
        }

        public static void CarManager BrandIdColorIdTest()
        {
            CarManager carManager = new  CarManager(new  EfCarDal());

            Console.WriteLine(" BrandId'ye göre ");
            foreach (var model in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(model.Descriptions);
            }
            Console.WriteLine(" ColorId'ye göre ");
            foreach (var model in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(model.Descriptions);
            }

            return carManager;
        }
    }
}
