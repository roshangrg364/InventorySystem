using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Sales_details
    {
        [Key]
        [Display(Name ="Sales_Data_id")]
        public int sales_data_id { get; set; }

        [Required]
        public int sales_id { get; set; }

        [Required(ErrorMessage = "Select the product")]
        [Display(Name = "Product")]
        public int product_id { get; set; }

        [Display(Name = "Quantity")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal  qty { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

        [Display(Name = "Total")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal total { get; set; }


        [ForeignKey("sales_id")]
        public virtual Salesummary salesvalue { get; set; }

        [ForeignKey("product_id")]
        public virtual Product productvalue { get; set; }
    }
}
