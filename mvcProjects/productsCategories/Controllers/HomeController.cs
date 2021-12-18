using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using productsCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace productsCategories.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("products")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("addProduct")]
        public IActionResult addProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }else{
                return View("Products");
            }
        }

        [HttpPost("addCategory")]
        public IActionResult addCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            }else{
                return View("Categories");
            }
        }

        [HttpPost("categorize")]
        public IActionResult Categorize(Association newAssociation)
        {
            _context.Add(newAssociation);
            _context.SaveChanges();
            return Redirect($"/product/{newAssociation.ProductId}");
        }

        [HttpGet("product/{productId}")]
        public IActionResult OneProduct(int productId)
        {
            Product oneProduct = _context.Products.Include(c => c.AssociationList).ThenInclude(c => c.Category).FirstOrDefault(p => p.ProductId == productId);
            ViewBag.AllCategories = _context.Categories;
            return View(oneProduct);
        }

        [HttpPost("addProductToCategory")]
        public IActionResult addToCategory(Association newAssociation)
        {
            _context.Add(newAssociation);
            _context.SaveChanges();
            return Redirect($"/category/{newAssociation.CategoryId}");
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult OneCategory(int categoryId)
        {
            Category oneCategory = _context.Categories.Include(c => c.ProductList).ThenInclude(c => c.Product).FirstOrDefault(p => p.CategoryId == categoryId);
            ViewBag.AllProducts = _context.Products;
            return View(oneCategory);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
