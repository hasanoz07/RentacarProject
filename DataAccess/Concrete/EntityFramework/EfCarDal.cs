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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentacarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentacarDbContext context = new RentacarDbContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 CarName=car.Name,
                                 BrandName=b.Name,
                                 ColorName=color.Name,
                                 DailyPrice=car.DailyPrice
                             };

                return result.ToList();
            }
        }
    }
}
