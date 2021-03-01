using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();
            //BrandTest();
            //CarTest();
            //AddColorTest();
            //AddBrandTest();
            //AddCarTest();
            //UpdateColorTest();
            //DeleteColorTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result= rentalManager.Add(new Rental { RentalId=7, CarId=3, CustomerId=1, RentDate=new DateTime(2021,02,25), ReturnDate=new DateTime(2021, 03, 01) });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void DeleteColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 2, ColorName = "Beyaz" });
        }

        private static void UpdateColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 1, ColorName = "Kırmızı" });
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Insert(new Car { CarId = 8, BrandId = 3, ColorId = 2, CarName = "C5", ModelYear = "2017", DailyPrice = 30500, Description = "Otomatik vites" });
            carManager.Insert(new Car { CarId = 5, BrandId = 2, ColorId = 1, CarName = "C", ModelYear = "2020", DailyPrice = 28000, Description = "Manuel vites" });
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Insert(new Brand { BrandId = 3, BrandName = "Audi" });
           
        }

        private static void AddColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Insert(new Color { ColorId = 6, ColorName = "Mor" });
            colorManager.Insert(new Color { ColorId = 7, ColorName = "Kurşuni" });
          
        }

        private static void CarTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            var result = carmanager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
         
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId);
                }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorId + "/" + color.ColorName);
                }
        }     
}
}
