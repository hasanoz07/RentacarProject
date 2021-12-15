using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=210,ModelYear=2018,Descriptions="Beyaz 2018 model Fiat Egea"},
                new Car{Id=2,BrandId=2,ColorId=3,DailyPrice=270,ModelYear=2015,Descriptions="Mavi 2015 model Volkswagen Polo"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=300,ModelYear=2014,Descriptions="Siyah 2014 model Volkswagen Passat"},
                new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=450,ModelYear=2014,Descriptions="Beyaz 2014 model BMW 320i"},
                new Car{Id=5,BrandId=3,ColorId=3,DailyPrice=600,ModelYear=2016,Descriptions="Mavi 2016 model BMW 525"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Bir araç eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
