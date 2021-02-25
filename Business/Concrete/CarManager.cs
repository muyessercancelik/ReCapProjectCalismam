using Business.Abstract;
using DataAccess.Absract;
using Entities.Concrete;
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

        public void Add(Car car)
        {
            if (car.Name.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.Name+" "+ "eklendi.");
            }
            else
            {
                Console.WriteLine("Car name alanı minimum 2 karakter olmalı ve Araba günlük fiyatı 0'dan büyük olmalıdır!");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
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

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.Name + " " + "güncellendi.");
        }
    }
}
