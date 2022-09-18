using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeCampi.Controllers
{
    public class İstatistikController : Controller
    {
        Context context = new Context();
       
        
        public ActionResult Index()
        {

            var CategoriCount = context.categories.Count();
           // var YazılımCount = context.Headings.Count(x => x.Category.Heading.Count);
            var write = context.Writers.Count(x => x.WriterName.Contains("a"));
            var CategoriMaxHeading = context.Headings.Max(x => x.Category.CategoryName);
            var TrueCount = context.categories.Count(x => x.CategoryStatus == true);
            var FalseCount = context.categories.Count(x => x.CategoryStatus == false);
          
            ViewBag.CategoryCount = CategoriCount;
          //  ViewBag.Heading = YazılımCount;
            ViewBag.Writer = write;
            ViewBag.HeadingMax = CategoriMaxHeading;
            ViewBag.StatusFark = (TrueCount - FalseCount);

            return View();

        }
    }
}