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
    public class ProductManager : IProductManager
    {

        IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductDal();
        }

        public ResultMesssage Add(Product entity)
        {
            #region Validation Ekleme
            ResultMesssage result = new ResultMesssage();
            result.isSuccess = false;



            //Burada Validation Koyacağız.

            if (entity.Name.Length == 0)
            {
                result.Message = "Ürün Adı Belirtmelisiniz";
                return result;
            }

            if (entity.Name.Length > 50)
            {
                result.Message = "Ürün Adı için Fazla Karakter Girdiniz";
                return result;
            }

            var _existingProduct = GetAll().Where(s => s.Name == entity.Name).FirstOrDefault();

            if (_existingProduct!=null)
            {
                result.Message = "Bu Ürün İsminyle Bir Ürün Kayıtlı Farklı Bir İsim Seçiniz";
                return result;
            }

            #endregion

            try
            {
                _productDal.Add(entity);
                result.isSuccess = true;
                return result;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir Hata Oluştu {0}", e.Message);
                return result;
                
            }

        }

        public ResultMesssage Delete(Product entity)
        {
            ResultMesssage result = new ResultMesssage();
            result.isSuccess = false;



            try
            {
                _productDal.Delete(entity);
                result.isSuccess = true;
                return result;

            }
            catch (Exception e)
            {

                result.Message = string.Format("Bir Hata Oluştu {0}", e.Message);
                return result;
            }
        }

        public Product Get(int id)
        {
            return _productDal.Get(id);
        }

        public IQueryable<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public ResultMesssage Update(Product entity)
        {
            #region Validation Ekleme
            ResultMesssage result = new ResultMesssage();
            result.isSuccess = false;



            //Burada Validation Koyacağız.

            if (entity.Name.Length == 0)
            {
                result.Message = "Ürün Adı Belirtmelisiniz";
                return result;
            }

            if (entity.Name.Length > 50)
            {
                result.Message = "Ürün Adı için Fazla Karakter Girdiniz";
                return result;
            }
            #endregion

            try
            {
                _productDal.Update(entity);
                result.isSuccess = true;
                return result;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir Hata Oluştu {0}", e.Message);
                return result;

            }
        }
    }
}
