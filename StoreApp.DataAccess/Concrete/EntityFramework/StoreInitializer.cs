using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    public class StoreInitializer: CreateDatabaseIfNotExists<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            #region Category içeriği list ile dolduruluyor
            List<Category> categories = new List<Category>()
            {
                new Category(){Name="Category 1"},
                new Category(){Name="Category 2"},
                new Category(){Name="Category 3"},
                new Category(){Name="Category 4"},
                new Category(){Name="Category 5"},
                new Category(){Name="Category 6"},
                new Category(){Name="Category 7"},

            };
            //Burada, yukarıdaki listede yer alan bilgileri context yardımı ile Category tablosuna kaydediyoruz.

            foreach (var i in categories)
            {
                //Contextteki her categories içerisine add ile ekliyoruz.

                //Ekleme Bu şekilde de olabilir
                Category cat = new Category() {
                    Name = i.Name,              
                };
                //Bu şekilde de olabilir
                context.Categories.Add(i);
            }

            context.SaveChanges();
            #endregion
            #region Product içeriği list ile dolduruluyor

            List<Product> products = new List<Product>()
            {
                new Product(){ Name="Product 1", Description="Description 1",Image="1.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-10)},

                new Product(){ Name="Product 2", Description="Description 2",Image="2.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-20)},

                new Product(){ Name="Product 3", Description="Description 3",Image="3.jpg",isHome=true, isApproved=true, isFeatured=true,Price=250,Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-25)},

                new Product(){ Name="Product 4", Description="Description 4",Image="4.jpg",isHome=false, isApproved=true, isFeatured=true,Price=200,Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-19)},

                new Product(){ Name="Product 5", Description="Description 5",Image="1.jpg",isHome=false, isApproved=true, isFeatured=true,Price=200,Stock=0, CategoryId=1,Date=DateTime.Now.AddDays(-12)},

                new Product(){ Name="Product 6", Description="Description 6",Image="2.jpg",isHome=true, isApproved=true, isFeatured=false,Price=300,Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-15)},

                new Product(){ Name="Product 7", Description="Description 7",Image="3.jpg",isHome=true, isApproved=true, isFeatured=true,Price=300,Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-14)},

                new Product(){ Name="Product 8", Description="Description 8",Image="4.jpg",isHome=false, isApproved=true, isFeatured=true,Price=350,Stock=0, CategoryId=2,Date=DateTime.Now.AddDays(-25)},

                new Product(){ Name="Product 9", Description="Description 9",Image="1.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-24)},

                new Product(){ Name="Product 10", Description="Description 10",Image="2.jpg",isHome=true, isApproved=true, isFeatured=false,Price=500,Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-60)},

                new Product(){ Name="Product 11", Description="Description 11",Image="3.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=50, CategoryId=2,Date=DateTime.Now.AddDays(-30)},

                new Product(){ Name="Product 12", Description="Description 12",Image="4.jpg",isHome=true, isApproved=true, isFeatured=false,Price=100,Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-45)},

                new Product(){ Name="Product 13", Description="Description 13",Image="1.jpg",isHome=true, isApproved=false, isFeatured=true,Price=100,Stock=200, CategoryId=3,Date=DateTime.Now.AddDays(-23)},

                new Product(){ Name="Product 14", Description="Description 14",Image="2.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=3,Date=DateTime.Now.AddDays(-14)},

                new Product(){ Name="Product 15", Description="Description 15",Image="3.jpg",isHome=true, isApproved=false, isFeatured=false,Price=100,Stock=100, CategoryId=3,Date=DateTime.Now.AddDays(-41)},

                new Product(){ Name="Product 16", Description="Description 16",Image="4.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=4,Date=DateTime.Now.AddDays(-10)},

                new Product(){ Name="Product 17", Description="Description 17",Image="1.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=4,Date=DateTime.Now.AddDays(-8)},

                new Product(){ Name="Product 18", Description="Description 18",Image="2.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=4,Date=DateTime.Now.AddDays(-1)},

                new Product(){ Name="Product 19", Description="Description 19",Image="3.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=0, CategoryId=5,Date=DateTime.Now.AddDays(-5)},

                new Product(){ Name="Product 20", Description="Description 20",Image="4.jpg",isHome=true, isApproved=false, isFeatured=false,Price=100,Stock=100, CategoryId=5,Date=DateTime.Now.AddDays(-6)},

                new Product(){ Name="Product 21", Description="Description 21",Image="1.jpg",isHome=true, isApproved=true, isFeatured=true,Price=100,Stock=100, CategoryId=5,Date=DateTime.Now.AddDays(-7)},

                 new Product(){ Name="Product 22", Description="Description 22",Image="2.jpg",isHome=true, isApproved=false, isFeatured=true,Price=100,Stock=0, CategoryId=5,Date=DateTime.Now.AddDays(-9)},


            };

            foreach (var i in products)
            {
                context.Products.Add(i);
            }

            context.SaveChanges();
            #endregion
        }
    }
}
