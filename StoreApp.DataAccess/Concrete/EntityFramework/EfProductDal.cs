using StoreApp.DataAccess.Abstract;
using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EFGenericDal<Product>, IProductDal
    {
        public List<Product> Get5TopProducts()
        {
            throw new NotImplementedException();
        }
    }
}
