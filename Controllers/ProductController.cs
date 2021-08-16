using M_Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M_Model.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product()
            {
                ID = 1,
                Name = "ASP.NET CORE MVC",
                Price = 350
            };

            return View(product);
        }
    }
}
