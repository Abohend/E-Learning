﻿using Learn.Entities.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Learn.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;   
        }
        public IActionResult Index()
        {
           var categories = _categoryRepository.GetAll();   
            return View();
        }
    }
}
