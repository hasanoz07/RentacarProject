using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
        ICarDal _carDal;
        public CarManager(ICarDal ıCarDal)
        {
            _carDal = ıCarDal;
        }
        [ValidationAspect(typeof(CarManager))]
        public IResult Add(Car car)
        {
            if (car.Name.Length>2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarManagerSuccessful.CarAddedSuccessful);
            }
            else
            {
                Console.WriteLine("Lütfen eklemek istediğiniz aracın ismi 2 karakterden uzun ve fiyatı 0 TL den büyük olmalı");
                return new ErrorResult(Messages.CarManagerError.CarAddedError);
            }
            
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarManagerSuccessful.CarDeletedSuccessful);
        }
        public IDataResult<List<Car>> GetAll()
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarManagerSuccessful.CarListedSuccessful) ;
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarManagerSuccessful.CarCarDetailSuccessful);
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult< List < Car >>(_carDal.GetAll(c => c.BrandId == brandId),Messages.CarManagerSuccessful.CarGetByBrandSuccessful) ;
        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId),Messages.CarManagerSuccessful.CarGetByColorSuccessful);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarManagerSuccessful.CarUpdatedSuccessful);
        }
    }
}
