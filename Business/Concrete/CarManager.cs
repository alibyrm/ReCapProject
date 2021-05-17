using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Carmanager new lendiğinde ilk consractor çalışacağı 
        //için bana bir ICarDal ver diyor.yani referans numarası verecek.

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Descriptions.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult("Ürün başarıyla eklendi");
            }
            return new ErrorResult("Ürün eklenemedi");

        }

        public IResult Delete(Car car)
        {
            
            _carDal.Delete(car);
            return new SuccessResult("Ürün silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour==21)
            //{
            //    return new ErrorDataResult<List<Car>>("Sistem bakımda");
            //}
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(),"Ürünler listelendi.");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetProductDetails(),"Araba detayları listelendi");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandID == id));
        }

        public IDataResult<List<Car>> GetCarsColorId(int id)
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorID == id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult( "Ürün güncellendi.");
        }
    }
}
