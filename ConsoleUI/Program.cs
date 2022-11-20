using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarGetAllTest();
            // BrandGetAllTest();
            // ColorGetAllTest();

            // BrandAddTest();
            // ColorAddTest();
            // CarAddTest();
            // UserAddTest();
            CustomerAddTest();

            // CarDeleteTest();
            // CarUpdateTest();
            // CarGetAllTest();

            // CarDetailsTest();
        }

        private static void CustomerAddTest()
        {
            Customer customer = new Customer
            {
                UserId = 1,
                CustomerId = 1,
                CompanyName = "Microsoft"
            };
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer);
        }

        private static void UserAddTest()
        {
            User user = new User
            {
                UserId = 1,
                FirstName = "Ferdi",
                LastName = "Aydoğdu",
                Email = "ferdi.aydogdu@gmail.com",
                Password = "123456"
            };
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(user);
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " - " + car.CarName + " - " + car.DailyPrice + " - " + car.ColorName);
            }
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 4,
                BrandId = 4,
                ColorId = 4,
                ModelYear = 2017,
                DailyPrice = 480,
                Description = "A8 Long"
            };
            carManager.Update(car);
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 4,
                BrandId = 4,
                ColorId = 4,
                ModelYear = 2017,
                DailyPrice = 420,
                Description = "A5"
            };
            carManager.Delete(car);
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 4,
                BrandId = 4,
                ColorId = 4,
                ModelYear = 2017,
                DailyPrice = 420,
                Description = "A5"
            };
            carManager.Add(car);
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color
            {
                ColorId = 4,
                ColorName = "Kırmızı"
            };
            colorManager.Add(color);
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand
            {
                BrandId = 4,
                BrandName = "Audi"
            };
            brandManager.Add(brand);
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description + ": " + car.DailyPrice);
            }
        }
    }
}
