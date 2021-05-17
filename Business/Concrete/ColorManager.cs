using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        //Colormanager new lendiğinde ilk consractor çalışacağı 
        //için bana bir IColorDal ver diyor.yani referans numarası verecek.

        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            
            _colorDal.Add(color);
            return new SuccessResult("Renk sisteme eklendi.");
        }

        public IResult Delete(Color color)
        {
           
            _colorDal.Delete(color);
            return new SuccessResult("Renk başarıyla sistemden silndi.");
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Color>>("Sistem bakımda");
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Renkler listelendi.");
        }

        public IDataResult<List<Color>> GeTAllByColor(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.Id == id));  //Id: ColorId
        }

        public IResult Update(Color color)
        {
            
            _colorDal.Update(color);
            return new SuccessResult("Renk başarıyla güncellendi.");
        }
    }
}
