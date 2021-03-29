﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Descript.Length>=2 && car.DailyPrice>=0)
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll().ToList();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll().Where(p => p.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll().Where(p => p.ColorId == id).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
