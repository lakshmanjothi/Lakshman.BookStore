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
        public string Index()
        {
            return "Lakshman";
        }
    }
}
