using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class PurchaseSummaryController : Controller
    {
        private readonly AppDbContext.inventorydbcontext _context;

        public PurchaseSummaryController(AppDbContext.inventorydbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<PurchaseSummary> summary = _context.purchasesummary.ToList();
            return View(summary);
        }

        public IActionResult Showdetails(int id)
        {
            List<PurchaseDetails> pr = _context.purchaseDetails.Where(a=>a.pch_id==id).ToList();
            var data = pr.Select(a => new
            {
                a.pdata_id,
                a.pch_id,
                a.product_id,
                a.price,
                a.qty,
                a.productvalue.product,
                a.purchasevalue.supvalue.FullName,
                a.total,
            }).ToList();
            return Json(data);
        }
    }
}
