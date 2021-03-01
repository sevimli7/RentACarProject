using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    
    //context: db tabloları ile proje claslarını ilişkilendirir.
    public class RentACarContext : DbContext//dbcontext entitiyframework içindeki bir metoddur
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= (localdb)\mssqllocaldb;Database=RentACar;Trusted_Connection=true");
            //bu metod, projemizin hangi veri tabanı ile ilişkili olduğunu belirteceğimiz yer
            //yukarıda server yazdığımız yerde = den sonra serverın olduğu IP yazılır. ama biz develop ortamında olduğumuzdan, adres giriyoruz.
            //hangi db ile çalışacağımızı tanıttık. şimdide hangi nesnem, hangi nesneye karşılık gelir onu tanımlamak için,aşağıda propları kullanacağız
        }
        public DbSet<Car> Cars { get; set; }//benim product nesnem products tablosuna eşit
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
