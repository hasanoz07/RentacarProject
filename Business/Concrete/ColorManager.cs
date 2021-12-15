using Business.Abstract;
using Business.Constants;
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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorManager))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorManagerSuccessful.ColorAddedSuccessful);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorManagerSuccessful.ColorDeletedSuccessful);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorManagerSuccessful.ColorListedSuccessful);
        }

        public IDataResult<Color> GetColorById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id), Messages.ColorManagerSuccessful.ColorGetByColorSuccessful);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorManagerSuccessful.ColorUpdatedSuccessful);

        }
    }
}
