﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerceFirst.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetAllList();
            return View(values);
        }

        ProductManager pm = new ProductManager(new EfProductRepository());

        public IActionResult ManProducts()
        {
            var values = pm.GetProductListWithCategory();
            return View(values);
        }
        
        public IActionResult WomanProducts()
        {
            var values = pm.GetProductListWithCategory();
            return View(values);
        }
    }
}
