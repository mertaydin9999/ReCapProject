using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear="2014",DailyPrice=15,Description="Opel"},
                new Car{Id=2,BrandId=1,ColorId=4,ModelYear="2015",DailyPrice=20,Description="Opel"},
                new Car{Id=3,BrandId=2,ColorId=4,ModelYear="2015",DailyPrice=30,Description="Tofask"},
                new Car{Id=4,BrandId=2,ColorId=5,ModelYear="2016",DailyPrice=25,Description="Tofask"},
                new Car{Id=5,BrandId=3,ColorId=5,ModelYear="2017",DailyPrice=15,Description="Ford"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
