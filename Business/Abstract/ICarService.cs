using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int idBrand);
        List<Car> GetCarsByColorId(int idColor);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
