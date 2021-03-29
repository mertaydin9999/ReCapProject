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
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { CarId = 7, BrandId = 3, ColorId = 2, ModelYear = "2020", DailyPrice = 200, Descript = "FIAT" };
            

            carManager.Add(car1);

            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.Descript);
            }
            
            
                
            
        }
    }
}
