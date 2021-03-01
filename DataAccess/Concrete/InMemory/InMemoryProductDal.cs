using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;        //global 
        public InMemoryCarDal() //constractor ile fake veri tabanı yaptık. oracle, sql server,postgres,mongodb
        {
            _cars = new List<Car> {
            new Car{ Id=1,BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=500, Description="THY"},
            new Car{ Id=2,BrandId=1, ColorId=2, ModelYear=2022, DailyPrice=550, Description="Tamer Yücedağ"},
            new Car{ Id=3,BrandId=2, ColorId=1, ModelYear=2021, DailyPrice=200, Description="Ayşe Akın"},
            new Car{ Id=4,BrandId=2, ColorId=1, ModelYear=2000, DailyPrice=300, Description="Tunç Reklam"},
            new Car{ Id=5,BrandId=3, ColorId=2, ModelYear=1990, DailyPrice=400, Description="Kaan Bilgin"},
            new Car{ Id=6,BrandId=3, ColorId=1, ModelYear=2010, DailyPrice=250, Description="Keloğlan Tic."},



            };
        }

        public void Add(Car car)
        {
            _cars.Add( car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {//gönderdiğim ürün ıd sine sahip listedeki ürünü bul demek. 
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
