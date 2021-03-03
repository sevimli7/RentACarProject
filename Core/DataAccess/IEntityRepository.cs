
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityReposityory<T> where T : class, IEntity, new()
    {// burada Tnin alabileceği değerleri kısıtladık where koşulu ile
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//expression ile filtreleme şartlarına gerek kalmadı
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        // List<T> GetAllByCategory(int categoryId); //ürünleri kategoriye göre filtrele
        //T Get metodu ile tek ürünü sorgulayabilecğimiz için artık  GetByCategory kısmına gerek kalmadı

    }
}
