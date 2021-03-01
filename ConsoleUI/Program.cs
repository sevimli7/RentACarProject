using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());

            //  brandManager.Add(new Entities.Concrete.Brand { BrandId = 4, BrandName = "BMW" }) ;
            // brandManager.Add(new Entities.Concrete.Brand { BrandId=5,BrandName="PORCHE"});
            

            RentACarContext context = new RentACarContext();

            //foreach ( var car in context.Cars)
            //{
            //    Console.WriteLine(car.Description);
            //}

            carManager.Add(new Car { Id=6, BrandId=2, ColorId=2, DailyPrice=0, ModelYear=2012, Description="Yeni araç"});

        }
    }
}
