using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Customer
    {
        [Key]
        [Display(Name ="Cus_ID")]
        public int cus_id { get; set; }
        [Required (ErrorMessage ="Please Enter the Customer Name")]
        [StringLength(50)]
        [Display(Name ="Full Name")]
        public String FullName { get; set; }
        [Required(ErrorMessage = "Please Enter the address")]
        [StringLength(50)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter the contact")]
        [StringLength(50)]
        [Display(Name = "Contacet No")]

        public  string Contact { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }

        [NotMapped]
        
        public IFormFile file { get; set; }
    }
}
