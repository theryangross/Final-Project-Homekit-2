using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Final_Project_Homekit_2.Models
{
    public class Category
    {
        public int CategoryID { get; set; } // PK
        
        [Required]
        [Display(Name="Category")]
        public string CategoryName { get; set; }
        
        public int ProductID { get; set; }  // FK
        
        public List<Product> Products { get; set; }   // Nav. Each Category can have one or many Products
    }
}