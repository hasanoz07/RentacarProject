using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
            _rentalDal = rentalDal;
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null||rental.ReturnDate<=DateTime.Now)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalManagerSuccessful.RentalAddedSuccessful);
            }
            return new SuccessResult(Messages.RentalManagerSuccessful.RentalAddedSuccessful);

        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalManagerSuccessful.RentalDeletedSuccessful);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalManagerSuccessful.RentalListedSuccessful);
        }

        public IDataResult<Rental> GetRentalById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), Messages.RentalManagerSuccessful.GetByRentalSuccessful);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalManagerSuccessful.RentalUpdatedSuccessful);
        }
    }
}
