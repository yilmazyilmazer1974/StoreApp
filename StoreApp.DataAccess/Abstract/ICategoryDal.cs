using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Abstract
{
    //ICategoryDal üzerinden tüm metodlara ulaşmış oluyoruz.
   public interface ICategoryDal: IGenericDal<Category>
    {

    }
}
