using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventorySystem.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace InventorySystem.Controllers
{
    public class CustomerController : Controller
    {
        //take repo and services refereenc
        // use dependency injection to inject them

        private readonly IWebHostEnvironment _environment;
        private AppDbContext.inventorydbcontext _context;
        public CustomerController(IWebHostEnvironment env,AppDbContext.inventorydbcontext context)
        {
           
            _environment = env;
            _context = context;
        }

        public IActionResult Index()
        {
            var cus = _context.customers.ToList();
            return View(cus);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer cus)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(_environment.WebRootPath, "images");
                if (cus.file != null && cus.file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(cus.file.FileName);
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                    {
                        await cus.file.CopyToAsync(fileStream);
                        cus.image = fileName;
                    }

                }
                _context.Add(cus);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(cus);

        }


        public IActionResult IsEnabledDisbled(int id, bool status)
        {
            Customer cus = _context.customers.Find(id);

            if (status == true)
            {

                cus.Status = "enabled";
            }
            else
            {
                cus.Status = "disabled";
            }
            _context.customers.Update(cus);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id > 0)
            {
                Customer cus = _context.customers.Find(id);
                return View(cus);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer cus)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(_environment.WebRootPath, "images");
                if (cus.file != null && cus.file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(cus.file.FileName);
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                    {
                        await cus.file.CopyToAsync(fileStream);
                        cus.image = fileName;
                    }

                }
                _context.Add(cus);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(cus);
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                Customer cus = _context.customers.Find(id);
                _context.customers.Remove(cus);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}




