using Business.Abstract;
using DataAccess;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine(color.ColorName + " " + "isimli Renk " + " " + "veri tabanından silindi.");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c=>c.ColorId==colorId);
        }

        public void Insert(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine(color.ColorName + " " + " veri tabanına eklendi.");
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine(color.ColorId + " " + "ID'li Renk " + " " + "veri tabanında güncellendi.");
        }
    }
}
