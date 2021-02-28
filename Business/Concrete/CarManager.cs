using Business.Abstract;
using DataAccess;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
 
namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c=>c.CarId == carId);
        }
        public void Insert(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.CarName + " " + "eklendi.");
            }
            else
            {
                Console.WriteLine("Car name alanı minimum 2 karakter olmalı ve Araba günlük fiyatı 0'dan büyük olmalıdır!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.CarName + " " + "silindi.");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.CarName + " " + "güncellendi.");

        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(b=>b.BrandId== brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(cId=>cId.ColorId==colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }










        /*public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int idBrand)
        {
            return _carDal.GetAll(c=>c.BrandId==idBrand);
        }

        public List<Car> GetCarsByColorId(int idColor)
        {
            return _carDal.GetAll(c=>c.ColorId==idColor);
        }

        
        }*/
    }
}
