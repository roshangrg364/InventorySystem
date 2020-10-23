using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystem.DataViewModel;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace InventorySystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext.inventorydbcontext _context;
        public ProductController(AppDbContext.inventorydbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> product = _context.products.ToList();
            ViewBag.products = product;
            List<Category> cat = _context.categories.ToList();
            ViewBag.categories = cat;
            return View();
        }
       
        [HttpPost]
        public IActionResult AddProduct(productviewmodel products)
         {
            if (products.p_id > 0)
            {
                Product pr = new Product();
                pr = _context.products.Find(products.p_id);
                pr.cat_id = products.cat_id;
                pr.product = products.product;
                pr.qty = products.qty;
                pr.price = products.price;
                _context.Update(pr);
                _context.SaveChanges();
                return Json(new { });
            }
            else
            {
                Product pr = new Product();
                
                pr.cat_id = products.cat_id;
                pr.product = products.product;
                pr.qty = products.qty;
                pr.price = products.price;
                _context.Add(pr);
                _context.SaveChanges();
                return Json(new { id = pr.p_id });
            }
           
       }


        public IActionResult Edit(int id)
        {
            Product pr = _context.products.Find(id);
            return Json(pr);
        }

        public IActionResult Delete(int id)
        {
            Product pr = _context.products.Find(id);
            _context.products.Remove(pr);
            _context.SaveChanges();
            return Json(pr);
        }
    }
}
