﻿using Harmic1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Harmic1.Controllers
{
    public class ProductController : Controller
    {
        private readonly HarmicContext _context;

        public ProductController(HarmicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("/product/{alias}-{id}.html")]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            } 

            var product = await _context.Products.Include(i => i.CategoryProduct)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.productReview = _context.ProductReviews.
                Where(i => i.ProductId == id && i.IsActive).ToList();
            ViewBag.productRelated = _context.Products.
                Where(i => i.ProductId != id && i.CategoryProductId == product.CategoryProductId).Take(5).
                OrderByDescending(i => i.ProductId).ToList();
            return View(product);
        }
    }
}
