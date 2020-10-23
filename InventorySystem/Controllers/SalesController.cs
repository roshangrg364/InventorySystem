using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystem.DataViewModel;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class SalesController : Controller
    {
        private readonly AppDbContext.inventorydbcontext _context;
        public SalesController(AppDbContext.inventorydbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Salesummary> summary = _context.salesummaries.ToList();
            ViewBag.salesummary = summary;
            List<Customer> cus = _context.customers.ToList();
            ViewBag.customers = cus;
            List<Category> cat = _context.categories.ToList();
            ViewBag.categories = cat;
            List<Product> prdt = _context.products.ToList();
            ViewBag.products = prdt;
            List<Sales_details> sales = _context.salesdetails.ToList();
            ViewBag.sales = sales;
            return View();
        }
        [HttpPost]
        public  IActionResult Add(salessummaryviewmodel sum)
        {
            Salesummary summary = new Salesummary();
            summary.cus_id = sum.cus_id;
            summary.total_amount = sum.total_amount;
            summary.discount = sum.discount;
            summary.vat = sum.vat;
            summary.net_total = sum.net_total;
            _context.Add(summary);
            _context.SaveChanges();
            
            foreach(var details in sum.details)
            {
                Sales_details saledetails = new Sales_details();
                saledetails.sales_id = summary.sales_id;
                saledetails.product_id = details.product_id;
                saledetails.qty = details.qty;
                saledetails.price = details.price;
                saledetails.total = details.total;

                _context.Add(saledetails);
                _context.SaveChanges();
                Product pr = _context.products.Find(saledetails.product_id);
                pr.qty = pr.qty - saledetails.qty;
                _context.products.Update(pr);
                _context.SaveChanges();
            }
            return Json(new { id=summary.sales_id});
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

        public IActionResult GetPriceList(int id)
        {
            Product pr = _context.products.Where(product => product.p_id == id).SingleOrDefault();
            return Json(pr);
        }

        public  IActionResult Bill(int id)
        {
            Salesummary sum = _context.salesummaries.Where(a => a.sales_id == id).SingleOrDefault();

            return View(sum);
        }
    }
}
