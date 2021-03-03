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



            RentACarContext context = new RentACarContext();

            //foreach ( var car in context.Cars)
            //{
            //    Console.WriteLine(car.Description);
            //}

            // carManager.Add(new Car { Id=6, BrandId=2, ColorId=2, DailyPrice=0, ModelYear=2012, Description="Yeni araç"});

            //CarDetails(carManager);

            BrandManager brandManager = new BrandManager(new EFBrandDal());
            brandManager.Add(new Brand{ BrandId=6, BrandName="papatya"}); //-marka ekleme
            brandManager.Update(new Brand { BrandId=1, BrandName="Tofaş" }); //- marka güncelleme
       
           



        }

        private static void CarDetails(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "-" + car.BrandName + "-" + car.ColorName + "-" + car.DailyPrice);
            }
        }
    }
}
