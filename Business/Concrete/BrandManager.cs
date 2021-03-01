using Business.Abstract;
using DataAccess;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine(brand.BrandName + " " + "isimli Marka " + " " + "veri tabanından silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b=>b.BrandId== brandId);
        }

        public void Insert(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine(brand.BrandName + " " + "veri tabanına eklendi.");
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine(brand.BrandId + " " + "ID'li Renk " + " " + "veri tabanında güncellendi.");
        }
    }
}
