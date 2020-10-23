using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.DataViewModel
{
    public class purchasedetailviewmodel
    {
      
        public int product_id { get; set; }

         public string product_name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal qty { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal price { get; set; }


        [Column(TypeName = "decimal(18,2)")]

        public decimal total { get; set; }



    }
}
