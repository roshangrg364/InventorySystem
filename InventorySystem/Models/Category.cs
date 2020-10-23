using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Category
    {
        [Key]
        [Display(Name ="Cat_Id")]
        public int cat_id { get; set; }

        [Required (ErrorMessage ="Please Add the Category")]
        [Display(Name ="Category Name")]
        public string category { get; set; }
    }
}
