using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        //Brandmanager new lendiğinde ilk consractor çalışacağı 
        //için bana bir IBrandDal ver diyor.yani referans numarası verecek.

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Marka başarıyla eklendi.");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Markalar silindi.");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Markalar listelendi");
        }

        public IDataResult<List<Brand>> GeTAllByBrand(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(c => c.Id == id)); //  ıd: brandId
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Marka başarıyla güncellendi.");
        }
    }
}
