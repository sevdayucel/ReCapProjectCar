﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }
        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç bilgisi eklendi.");
            }
            else
            {
                Console.WriteLine("Günlük fiyat değeri 0 dan küçük olamaz : {car.DailyPrice}");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç bilgisi silindi.");

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }
        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);

        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);

        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _carDal.GetAll(c => c.ModelYear.Contains(year) == true);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Ara. bilgisi güncellendi.");
            }
            else
            {
                Console.WriteLine("Günlük fiyat değeri 0 dan küçük olamaz: {car.DailyPrice}");
            }
        }
}
