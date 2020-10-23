using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Product
    {
        [Key]
        [Display(Name ="P_Id")]
        public int p_id { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage="please Enter category")]
        public int cat_id { get; set; }

        [Required(ErrorMessage ="Enter the product")]
        [Display(Name ="Product Name")]
        [StringLength(255)]
        public string product { get; set; }

        [Required(ErrorMessage = "Enter the quantity")]
        [Display(Name = "qty")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal qty { get; set; }

        [Required(ErrorMessage = "Enter the Price")]
        [Display(Name = "Price")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal price { get; set; }

        [ForeignKey ("cat_id")]
        public virtual Category catvalue { get; set; }

    }
}
