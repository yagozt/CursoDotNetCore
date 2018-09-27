using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Dtos;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Web.Models;
using StoreOfBuild.Web.ViewModels;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _categoryStorer;
        private readonly IRepository<Category> _categoryRepository;

        public CategoryController(CategoryStorer categoryStorer, IRepository<Category> categoryRepository)
        {
            _categoryStorer = categoryStorer;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var viewmodel =_categoryRepository.All().Select(c => new CategoryViewModel { Name = c.Name, Id = c.Id });
            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult CreateOrEdit(int id)
        {
            if(id > 0)
            {
                var category = _categoryRepository.GetById(id);
                var categoryViewModel = new CategoryViewModel {Id = category.Id, Name = category.Name };
                return View(categoryViewModel);
            }
            else
            {
                return View();
            }
           
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryViewModel category)
        {
            _categoryStorer.Store(category.Id, category.Name);
            return RedirectToAction("Index");
        }
    }
}
