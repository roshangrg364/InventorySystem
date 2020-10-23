using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class PurchaseSummary
    {
        [Key]
        [Display(Name ="purchase_Id")]
        public int pch_id { get; set; }

        [Required(ErrorMessage =" please select the supplier")]
        [Display(Name ="Supplier")]
        public int sup_id { get; set; }

        [Required(ErrorMessage = "Total Amount is empty")]
        [Display(Name = "Total Amount")]
        [Column(TypeName = "decimal(18,2)")]

        public decimal total { get; set; }

        
        [Display(Name = "Discount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal discount { get; set; }
       
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Vat")]
        
        public decimal vat { get; set; }

        [Required(ErrorMessage = "Net total is empty")]
        [Display(Name = "Net Total")]
        [Column(TypeName = "decimal(18,2)")]

        public decimal net_total { get; set; }


        [ForeignKey("sup_id")]
        public virtual Supplier supvalue { get; set; }


        public virtual List<PurchaseDetails> details { get; set; }

    }
}
