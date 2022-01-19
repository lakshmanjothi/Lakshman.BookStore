using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lakshman.BookStore.Controllers
{
    //Inherited from Controller class - using Microsoft.AspNetCore.Mvc;
    public class HomeController: Controller
    {
        //Action method
        public ViewResult Index()
        {
            //var obj = new { Id = 1, Name = "Lakshman" };
            //return View(obj);
            //absolute path - return View("~/TempView/Index.cshtml");
            //relative path
            return View("../../TempView/Index");
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
