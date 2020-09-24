using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Abstract
{
   public interface IGenericDal<T> where T:class
    {
        //T Denen yer, Product, Category vb Entityler olacak

        T Get(int id);
        //IQueryable'ye where wb sorgu ekleyebiliyoruz.
        IQueryable<T> GetAll();

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
