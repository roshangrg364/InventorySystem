using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Salesummary
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Display(Name ="Sales_id")]
        public int sales_id { get; set; }

        [Required(ErrorMessage ="Please select the customer")]
        [Display(Name ="Customer")]
        public int cus_id { get; set; }

        [Required (ErrorMessage ="Enter the amount")]
        [Display(Name ="Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal total_amount { get; set; }

        [Display(Name ="Discount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal   discount { get; set; }

        [Display(Name ="vat")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal vat { get; set; }

        [Required(ErrorMessage ="Net amount is empty")]
        [Display(Name ="Net Total")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal net_total { get; set; }

        [ForeignKey("cus_id")]
        [Column(TypeName = "decimal(18,2)")]
        public virtual Customer cus_value { get; set; }


        public virtual List<Sales_details> details { get; set; }


    }
}
