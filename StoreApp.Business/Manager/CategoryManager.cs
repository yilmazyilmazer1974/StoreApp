using StoreApp.Business.Abstract;
using StoreApp.DataAccess.Abstract;
using StoreApp.DataAccess.Concrete.EntityFramework;
using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Business.Manager
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _categoryDal;

        public CategoryManager()
        {
            _categoryDal = new EfCategoryDal();
        }

        public ResultMesssage Add(Category entity)
        {

            #region Validation Ekleme
            ResultMesssage result = new ResultMesssage();
            result.isSuccess = false;



            //Burada Validation Koyacağız.

            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori Adı Belirtmelisiniz";
                return result;
            }

            if (entity.Name.Length > 50)
            {
                result.Message = "Kategori Adı için Fazla Karakter Girdiniz";
                return result;
            } 
            #endregion

            //Hata Olmadıysa try catch bloğunu işin içine katarak kaydetme işlemi yaptırılıyor.
            try
            {
                _categoryDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir Hata Oluştu:{0}",e.Message);                
                return result;
               
            }


            return result;

        }

        public ResultMesssage Delete(Category entity)
        {
            ResultMesssage result = new ResultMesssage();
            result.isSuccess = false;

            

            try
            {
                _categoryDal.Delete(entity);
                result.isSuccess = true;
                return result;

            }
            catch (Exception e)
            {

                result.Message = string.Format("Bir Hata Oluştu {0}", e.Message);
                return result;
            }


          
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(id);
        }

        public IQueryable<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public ResultMesssage Update(Category entity)
        {
            #region Validation Ekleme
            ResultMesssage result = new ResultMesssage();
            result.isSuccess = false;



            //Burada Validation Koyacağız.

            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori Adı Belirtmelisiniz";
                return result;
            }

            if (entity.Name.Length > 50)
            {
                result.Message = "Kategori Adı için Fazla Karakter Girdiniz";
                return result;
            }
            #endregion

            try
            {
                _categoryDal.Update(entity);
                result.isSuccess = true;
                return result;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir Hata Oluştu", e.Message);
                return result;

        
            }
        }
    }
}
