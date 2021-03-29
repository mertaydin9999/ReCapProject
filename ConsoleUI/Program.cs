using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car { Id = 7, BrandId = 3, ColorId = 2, ModelYear = "2020", DailyPrice = 200, Description = "FIAT" };
            carManager.Add(car1);
            carManager.Delete(car1);
            
            carManager.Update(car1);
            
                foreach (var car in carManager.GetAll())
                {

                    Console.WriteLine(car.Description);
                }
            
        }
    }
}
