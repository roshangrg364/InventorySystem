using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class PurchaseDetails
    {

        [Display(Name = "Purchase Data Id")]
        [Key]
        public int pdata_id { get; set; }

        [Required]
        public int pch_id { get; set; }

        [Required]
        public int product_id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal qty { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal total { get; set; }

        [ForeignKey("pch_id")]

        public virtual PurchaseSummary purchasevalue { get; set; }

        [ForeignKey("product_id")]

        public virtual Product productvalue { get; set; }
    }
}
