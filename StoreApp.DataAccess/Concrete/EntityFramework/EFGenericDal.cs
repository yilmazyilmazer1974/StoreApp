﻿using StoreApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    public class EFGenericDal<T> : IGenericDal<T> where T : class
    {
        private StoreContext context = new StoreContext();

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            //Burada liste döndürdüğü için return diyoruz.
          return  context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
          return  context.Set<T>();
        }

        public void Update(T entity)
        {
            // Değişen alanların Güncellemesi yapılıyor.
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }

}
