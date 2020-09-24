using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Abstract
{
    //Eklenen interface ile en çok kullanan metodlar ekleniyor.
  public   interface IOrderDal:IGenericDal<Order>
    {
    }
}
