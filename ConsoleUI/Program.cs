using Business.Abstract;
using Business.Concrete;
using DataAccess.Cocrete.EntityFramework;
//using DataAccess.Cocrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Üretim tarihi: {0}",car.ModelYear);
            //    Console.WriteLine("Açıklama: {0}", car.Description);
            //    Console.WriteLine("ModelAdı: {0}",car.BrandName);
            //    Console.WriteLine("Renk: {0}",car.ColorName);
            //    Console.WriteLine("Günlük Kiralama Bedeli: {0}",car.DailyPrice);
            //    Console.WriteLine("\n********************************\n");
            //}

            //ICarService carService = new CarManager(new EfCarDal());
            //foreach (var car in carService.GetAll())
            //{

            //}
            //var result = carService.GetAll();
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Data);
            //}
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetAll();
            if (result.Success)
            {


                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarID);
                }
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Console.WriteLine("Araba Kiralama Listesi\n");
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
