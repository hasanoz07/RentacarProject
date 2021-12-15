using Business.Concrete;
using Business.Constants;
using Core.Utilities.Helpers.GuidHelper;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuidHelper.CreateGuid());
            
            /*
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            Console.WriteLine(rentalManager.Update(new Rental
            {
                Id = 1002,
                CustomerId = 1,
                CarId = 1,
                RentDate = DateTime.Now,
                ReturnDate = new DateTime(2021, 11, 29)



            }).Message);

                */

            //BrandAdd(brandManager);
            //ColorAdd(colorManager);
            //AddCar(carManager);

            //UserAdd(userManager);
            //CustomerAdd();






            /*
            Console.WriteLine(   rentalManager.Add(new Rental
            { 
                CustomerId = 1, 
                CarId = 1002, 
                RentDate = DateTime.Now,
                ReturnDate=null
            }).Message);
            
            */
            /*
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Name);
            }
            */




        }

        private static void UserAdd(UserManager userManager)
        {
            Console.WriteLine(userManager.Add(new User
            {
                FirstName = "Ahmet",
                LastName = "Çolak",
                Email = "acolak@gmail.com",
                Password = "123456ahmet"
            }).Message);
        }

        private static void AddCar(CarManager carManager)
        {
            Console.WriteLine(carManager.Add(new Car
            {
                ColorId = 4,
                BrandId = 3,
                Name = "BMW 525",
                DailyPrice = 375,
                ModelYear = 2014,
                Descriptions = "Gece Mavisi 2014 model BMW 525 1.6"

            }).Message);
        }

        private static void ColorAdd(ColorManager colorManager)
        {
            Console.WriteLine(colorManager.Add(new Color
            {
                Name = "Gece Mavisi"
            }).Message);
        }

        private static void BrandAdd(BrandManager brandManager)
        {
            Console.WriteLine(brandManager.Add(new Brand
            {
                Name = "Mercedes"
            }).Message);
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(new Customer
            {
                UserId = 1,
                CompanyName = "OZ SOFTWARE"

            }).Message);
        }

        
    }
}
