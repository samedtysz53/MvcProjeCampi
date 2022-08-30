using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFrameWork;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace MvcProjeCampi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList() 
        {
           var CategoryValues = cm.GetList();
            return View(CategoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddCategory(Category p)
        {
            //  cm.CategoryAddB(p);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result=categoryValidator.Validate(p);
            if (result.IsValid) 
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else 
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
    }
}