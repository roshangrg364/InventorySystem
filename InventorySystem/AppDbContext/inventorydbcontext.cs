using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using InventorySystem.AppDbContext;
using InventorySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.AppDbContext
{
    public class inventorydbcontext : DbContext
    {
        public inventorydbcontext(DbContextOptions<inventorydbcontext> options):base(options)
            {
            }

        public DbSet<Customer>  customers { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<PurchaseSummary> purchasesummary { get; set; }
        public DbSet<PurchaseDetails> purchaseDetails { get; set; }

        public DbSet<Salesummary> salesummaries { get; set; }

        public DbSet<Sales_details> salesdetails { get; set; }
    }
}
