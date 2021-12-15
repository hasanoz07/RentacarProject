using Business.Abstract;
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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal ıBrandDal)
        {
            _brandDal = ıBrandDal;
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
           return new SuccessResult(Messages.BrandManagerSuccessful.BrandAddedSuccessful);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandManagerSuccessful.BrandDeletedSuccessful);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.CarManagerSuccessful.CarListedSuccessful);
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.Id==id), Messages.BrandManagerSuccessful.BrandGetByBrandSuccessful);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandManagerSuccessful.BrandUpdatedSuccessful);
        }
    }
}
