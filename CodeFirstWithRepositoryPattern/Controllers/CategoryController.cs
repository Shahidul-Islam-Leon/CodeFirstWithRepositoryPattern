using CodeFirstWithRepositoryPattern.Models;
using CodeFirstWithRepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstWithRepositoryPattern.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository cr = new CategoryRepository();
        // GET:Category
        public ActionResult Index()
        {
            return View(cr.GetAllData());
        } 
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            cr.Insert(cat);

            return RedirectToAction("Index");
        }
    }
}