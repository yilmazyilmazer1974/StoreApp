using StoreApp.Business.Abstract;
using StoreApp.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        //Burada Ürünler Getirileceği için gerekli Manager Eklemelerini yapacağız

        IProductManager _productManager;
        ICategoryManager _categoryManager;

        public HomeController()
        {
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
        }


        public ActionResult Index()
        {
            var products = _productManager.GetAll()
                .Where(s => s.isApproved == true && s.isHome == true);
            return View(products);
        }

        public ActionResult Details(int? id)
        {
            var product = _productManager.Get(id.Value);
            return View(product);
        }
    }
}