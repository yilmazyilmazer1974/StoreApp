using StoreApp.Business.Abstract;
using StoreApp.Business.Manager;
using StoreApp.Entity;
using StoreApp.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {

        ICategoryManager _categoryManager;

            public CategoryController()
        {
            _categoryManager = new CategoryManager();
        }

        public ActionResult Index()
        {
            var category = _categoryManager.GetAll().ToList();

            return View(category);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                _categoryManager.Add(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _categoryManager.Get(id);


            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                _categoryManager.Update(category);

                TempData["Updated"] = category.Name;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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

        public PartialViewResult CategoryMenu()
        {
            var categories = _categoryManager.GetAll().Select(i => new CategoryModel() {

                Id = i.Id,
                Name = i.Name,
                ProductCount = i.Products.Where(s=>s.isApproved==true).Count(),

            }).ToList();

            return PartialView(categories);
        }

    }
}
