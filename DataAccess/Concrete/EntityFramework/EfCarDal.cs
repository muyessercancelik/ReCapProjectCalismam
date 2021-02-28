using DataAccess.Absract;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.DTOs;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyCarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyCarDatabaseContext context = new MyCarDatabaseContext())
            {
                var result = from c in context.Cars // Ürünlerle Kategorileri join et demek
                             join a in context.Colors on c.ColorId equals a.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId, ColorName= a.ColorName, BrandName=b.BrandName,
                                 DailyPrice=c.DailyPrice
                                 
                             };
                return result.ToList();
            }
        }
    }
}
