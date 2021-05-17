using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Cocrete.EntityFramework
{
    class EfUserDal:EfEntityRepositoryBase<User,Re_CapDbContext>,IUserDal
    {
    }
}
