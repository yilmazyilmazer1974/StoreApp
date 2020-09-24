using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Abstract
{
    //IProduct Dal özel fonksiyonları da içerisine alıyor
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> Get5TopProducts();
    }
}
