using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.DataViewModel
{
    public class salesdetailsviewmodel
    {
        

        [Display(Name = "Product")]
        public int product_id { get; set; }

        [Display(Name = "Quantity")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal qty { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

        [Display(Name = "Total")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal total { get; set; }


       
    }
}
