﻿using Microsoft.AspNetCore.Mvc;
using TheFinalFarmer.Models;

namespace TheFinalFarmer.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }

        public IActionResult Edit(int? id) 
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };

            return View(category);
        }   
    }
}
