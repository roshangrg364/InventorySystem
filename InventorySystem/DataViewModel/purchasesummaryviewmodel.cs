using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.DataViewModel
{
    public class purchasesummaryviewmodel
    {
       
        public int sup_id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal total_amount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal vat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal netamount { get; set; }


        public List<purchasedetailviewmodel> purchase_details { get; set; }
    }
}
