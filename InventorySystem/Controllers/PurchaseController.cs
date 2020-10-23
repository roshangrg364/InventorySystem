using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using InventorySystem.DataViewModel;
using InventorySystem.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

namespace InventorySystem.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly AppDbContext.inventorydbcontext _context;
        public PurchaseController(AppDbContext.inventorydbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Supplier> supplier = _context.suppliers.Where(sup => sup.Status == "enabled").ToList();
            ViewBag.suppliers = supplier;
            List<Category> cat = _context.categories.ToList();
            ViewBag.categories = cat;
            List<Product> products = _context.products.ToList();
            ViewBag.product = products;
            List<PurchaseDetails> prdetail = _context.purchaseDetails.ToList();
            ViewBag.purchasedetails = prdetail;


            return View();
        }

        public IActionResult GetProductList(int id)
        {
            try
            {
                List<Product> product = _context.products.Where(product => product.cat_id == id).ToList();
                return Json(product);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public IActionResult GetPrice(int id)
        {
            Product pr = _context.products.Where(product => product.p_id == id).SingleOrDefault();
            return Json(pr);
            
        }
        [HttpPost]
        public  IActionResult Add(purchasesummaryviewmodel allpurchase)
       {
            PurchaseSummary sum = new PurchaseSummary();
            sum.sup_id = allpurchase.sup_id;
            sum.total = allpurchase.total_amount;
            sum.discount = allpurchase.discount;
            sum.vat = allpurchase.vat;
            sum.net_total = allpurchase.netamount;
            _context.Add(sum);
            _context.SaveChanges();
           
          foreach(var purchasedetail in allpurchase.purchase_details)
           {

                PurchaseDetails details = new PurchaseDetails();
                details.pch_id = sum.pch_id;
                details.product_id = purchasedetail.product_id;
                details.qty = purchasedetail.qty;
                details.price = purchasedetail.price;
                details.total = purchasedetail.total;

                _context.Add(details);
                Product Prdt = _context.products.Find(details.product_id);
                Prdt.qty = Prdt.qty + details.qty;
                _context.products.Update(Prdt);
                _context.SaveChanges();

            }
            return Json(new { id = sum.pch_id });
       }
    
        public IActionResult Bill(int id)
        {
          PurchaseSummary pr = _context.purchasesummary.Where(a =>a.pch_id== id).SingleOrDefault();
          
            return View(pr);
        }
    }

 

}
