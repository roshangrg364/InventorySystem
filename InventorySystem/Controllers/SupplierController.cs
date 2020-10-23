using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventorySystem.AppDbContext;
using InventorySystem.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Runtime.CompilerServices;


namespace InventorySystem.Controllers
{
    public class SupplierController : Controller
    {

        private IWebHostEnvironment _environment;
        private readonly inventorydbcontext _context;

        public SupplierController(inventorydbcontext context,IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;

        }
        public IActionResult Index()
        {
            var sup = _context.suppliers.ToList();
            return View(sup);
        }
        //GET
        public IActionResult Createsupplier()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Createsupplier( Supplier sup)
        {
            if(ModelState.IsValid)
            {
                var uploads = Path.Combine(_environment.WebRootPath, "images");
                if (sup.file != null && sup.file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(sup.file.FileName);
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                    {
                        await sup.file.CopyToAsync(fileStream);
                        sup.image = fileName;
                    }

                }
                _context.Add(sup);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(sup);
        }


        public IActionResult IsEnabledDisabled(int id, bool status)
        {
            var sup = _context.suppliers.Find(id);
            if(status ==true)
            {
               
                sup.Status = "enabled";
            }
            else
            {
                sup.Status = "disabled";
            }
            _context.suppliers.Update(sup);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Editsupplier(int id)
        {
            if(id>0)
            {
                Supplier sup = _context.suppliers.Find(id);
                return View(sup);
            }
            return View();
        }


        [HttpPost]
        public IActionResult Editsupplier(Supplier sup)
        {
           
                if (ModelState.IsValid)
                {
                    var uploads = Path.Combine(_environment.WebRootPath, "images");
                    if (sup.file != null && sup.file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(sup.file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            sup.file.CopyTo(fileStream);
                            sup.image = fileName;
                        }

                    }
                    _context.Update(sup);
                     _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(sup);
            }

        public IActionResult Delete(int id)
        {
            if(id>0)
            {
                Supplier sup = _context.suppliers.Find(id);
                _context.suppliers.Remove(sup);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
      
