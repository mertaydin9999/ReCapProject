using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Brand brand = new Brand { BrandId = 3, BrandName = "2015" };
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand);
            ColorTest();
            CarTest();
            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.Descript +" "+car.BrandName + " "+car.ColorName+" "+car.DailyPrice);
            }


        }

        private static void ColorTest()
        {
            Color color = new Color { ColorId = 2, ColorName = "Kirmizi" };
            

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color);
            
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { CarId = 7, BrandId = 3, ColorId = 2, ModelYear = "2020", DailyPrice = 200, Descript = "Opel" };


            carManager.Add(car1);

            
        }
    }
}
