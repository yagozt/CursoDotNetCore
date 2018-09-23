using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiddlewareAvancado.Models;
using MiddlewareAvancado.Repository;

namespace MiddlewareAvancado.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Product product)
        {
            return View();
        }
        
    }
}