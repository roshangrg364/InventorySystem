using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventorySystem.AppDbContext;
using InventorySystem.Models;


namespace InventorySystem.Controllers
{
    public class CategoryController : Controller
    {
        private readonly inventorydbcontext _context;

        public CategoryController(inventorydbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> category = _context.categories.ToList();
            ViewBag.categories = category;

            return View();
        }

        [HttpPost]
        public IActionResult Add(DataViewModel.CategoryViewModel categories)
        {
            try
            {

                if (categories.cat_id > 0)
                {
                   
                        Category cat = _context.categories.Find(categories.cat_id);
                        cat.category = categories.category;
                        _context.Update(cat);
                        _context.SaveChanges();
                        return Json(new { success = true });
                    
                }
                else
                {
                  
                        Category cat = new Category();
                        cat.category = categories.category;
                        _context.Add(cat);
                        _context.SaveChanges();
                        return Json(new { success = true, cid = cat.cat_id });
                   

                }
              //  return Json(new { success = false });

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public IActionResult Edit(int id)
        {
            Category cat = _context.categories.Find(id);
            return Json(new { id = cat.cat_id, name = cat.category });
        }

        public IActionResult Delete(int id)
        {

            if (id > 0)
            {
                Category cat = _context.categories.Find(id);
                _context.categories.Remove(cat);
                _context.SaveChanges();
                return Json(new { });
            }
            return BadRequest();
        }
    }



}
