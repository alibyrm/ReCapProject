using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Cocrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,Re_CapDbContext>,ICustomerDal
    {
    }
}
