using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            this._rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId);
            if (rental.ReturnDate.Equals(new DateTime(0002, 02, 2)) || result != null)
            {
                return new ErrorResult("Araba henüz geri verilmedi.");
            }
            //if (result == null)
            //{
            _rentalDal.Add(rental);
            //}
            return new SuccessResult("Kira gerçekleşti.");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Araba geri teslim edildi.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Rental>>("Sistem bakımda.");
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "Kiralik araba listesi");
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id));
        }
    }
}
