using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    [Table("Product")]
   public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }


        public bool  isApproved { get; set; }
        public bool isHome { get; set; }
        public bool isFeatured { get; set; }

        //Burada Relationslar tutuluyor

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
