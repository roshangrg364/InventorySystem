using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class SaleSummaryController : Controller
    {

        private readonly AppDbContext.inventorydbcontext _context;
        public SaleSummaryController( AppDbContext.inventorydbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Salesummary> sum =_context.salesummaries.ToList();
            return View(sum);
        }

        public IActionResult GetDetails(int id)
        {
            List<Sales_details> details = _context.salesdetails.Where(a => a.sales_id == id).ToList();
            var data = details.Select(a => new
            {
                a.product_id,
                a.productvalue.product,
                a.qty,
                a.price,
                a.total,
            }).ToList();
           
            return Json(data);
        }
    }
}
