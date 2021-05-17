using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Cocrete.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental,Re_CapDbContext>,IRentalDal
    {
    }
}
