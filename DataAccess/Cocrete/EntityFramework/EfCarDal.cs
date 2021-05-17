using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Cocrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Re_CapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (Re_CapDbContext context=new Re_CapDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.Id
                             join co in context.Colors
                             on c.ColorID equals co.Id
                             select new CarDetailDto
                             {
                                 Description = c.Descriptions,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
