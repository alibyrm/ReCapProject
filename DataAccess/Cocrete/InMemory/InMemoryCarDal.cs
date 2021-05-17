//using DataAccess.Abstract;
//using Entities.Concrete;
//using Entities.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataAccess.Cocrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car> 
//            {
//                //veritabaınından geliyormuş gibi simule ettik.
//                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=600,Descriptions="Volkswagen Passat"},
//                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2008,DailyPrice=500,Descriptions="Volkswagen Jetta"},
//                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2002,DailyPrice=400,Descriptions="Dacia Duster"},
//                new Car{Id=4,BrandId=3,ColorId=2,ModelYear=2005,DailyPrice=700,Descriptions="Audi A4"},
//                new Car{Id=5,BrandId=4,ColorId=1,ModelYear=2018,DailyPrice=650,Descriptions="Toyota Corolla"},
//                new Car{Id=6,BrandId=1,ColorId=4,ModelYear=2015,DailyPrice=450,Descriptions="Volkswagen Polo"},
//                new Car{Id=7,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=400,Descriptions="Dacia Logan"},
//                new Car{Id=8,BrandId=2,ColorId=2,ModelYear=2013,DailyPrice=425,Descriptions="Dacia Stepway"},
//                new Car{Id=9,BrandId=3,ColorId=4,ModelYear=2015,DailyPrice=1000,Descriptions="Audi R8"},
//                new Car{Id=10,BrandId=3,ColorId=3,ModelYear=2017,DailyPrice=900,Descriptions="Audi Sedan"},
//                new Car{Id=11,BrandId=4,ColorId=3,ModelYear=2014,DailyPrice=1000,Descriptions="Toyota Supra"},
//                new Car{Id=12,BrandId=4,ColorId=2,ModelYear=2019,DailyPrice=900,Descriptions="Toyota Hilux"},
//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
//            _cars.Remove(carToDelete);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public void Update(Car car)
//        {
//            //gönderdiğim ürün ıd sine sahip olan listedeki ürünü bul.
//            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
//            carToUpdate.BrandID = car.BrandID;
//            carToUpdate.ColorID = car.ColorID;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Descriptions = car.Descriptions;
//        }

//        public List<Car> GetAllByBrand(int brandId)
//        {
//            return _cars.Where(c => c.BrandId == brandId).ToList();
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarDetailDto> GetProductDetails()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
