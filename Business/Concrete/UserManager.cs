using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.UserManagerSuccessful.UserAddedSuccessful);
        }

        public IResult Delete(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.UserManagerSuccessful.UserDeletedSuccessful);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.UserManagerSuccessful.UserListedSuccessful);
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userdal.Get(u => u.Email == email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userdal.GetClaims(user));
        }

        public IDataResult<User> GetUserById(int id)
        {
            return new SuccessDataResult<User>(_userdal.Get(u => u.Id == id),Messages.UserManagerSuccessful.GetByUserSuccessful);
        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.UserManagerSuccessful.UserUpdatedSuccessful);
        }
    }
}
