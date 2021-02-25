using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Absract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        /*List<Car> GetAll();
        List<Car> GetByBrand(int brandId );
        List<Car> GetByColor(int colordId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);*/
    }
}
