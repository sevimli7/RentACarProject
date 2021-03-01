using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id); //ürünleri kategoriye göre getir
        List<Car> GetCarsByColorId(int id); //ürünleri kategoriye göre getir
       
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
