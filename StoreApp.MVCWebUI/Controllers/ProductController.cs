using StoreApp.Business.Abstract;
using StoreApp.Business.Manager;
using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace StoreApp.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        //İlk OlarakManager Katmanını içeriye almalıyız ki işlem yapabilelim.


        IProductManager _productManager;
        ICategoryManager _categoryManager;

        public ProductController()
        {
            //dependency injection
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
        }
       
        public ActionResult Index()
        {
            var products = _productManager.GetAll().ToList();

            return View(products);
        }




        public ActionResult List()
        {
            var products = _productManager.GetAll().Where(i=>i.isApproved==true).OrderByDescending(i=>i.Date).ToList();

            return View(products);
        }

        
        public ActionResult Details(int id)
        {
            return View();
        }

       
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(_categoryManager.GetAll().ToList(), "Id", "Name");

            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Product product)
        {
      

            try
            {
                ViewBag.Categories = new SelectList(_categoryManager.GetAll().ToList(), "Id", "Name");
                _productManager.Add(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            //Burada Dropdownlist için ViewBag ile Category'leri Göndermem gerekiyor.            

            var product = _productManager.Get(id);

            ViewBag.Categories = new SelectList(_categoryManager.GetAll().ToList(), "Id", "Name", product.CategoryId);

            return View(product);
        }

        
        [HttpPost]
        public ActionResult Edit(Product entity)
        {
            try
            {
                _productManager.Update(entity);

                TempData["Updated"] = entity.Name;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Delete(int id)
        {
            return View();
        }

      
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
