using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
            new Car{CarId=1, BrandId=1, ColorId=1, CarName="C3 Aircross", ModelYear="2000", DailyPrice=3000, Description="1.2 PureTech"},
            new Car{CarId=2, BrandId=1, ColorId=2, CarName="C4 Cactus", ModelYear="2005", DailyPrice=5000, Description="1.5 BlueHDI"},
            new Car{CarId=3, BrandId=2, ColorId=2, CarName="EcoSport", ModelYear="2020", DailyPrice=2000, Description="1.0 EcoBoost"},
            new Car{CarId=4, BrandId=2, ColorId=3, CarName="Kuga", ModelYear="2019", DailyPrice=6000, Description="1.5 EcoBlue"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
     
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c=> c.BrandId==brandId).ToList();
        }
        public List<Car> GetByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.CarId = car.CarId;
        }
    }
}
