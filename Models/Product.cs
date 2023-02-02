using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Karrot.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        public IdentityUser Owner { get; set; }
        
        [Required]
        [Display(Name = "Description")]
        public string ProductDescription { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        public string ProductName { get; set; }
        
        [Required]
        [Display(Name = "Price")]
        public double ProductPrice { get; set; }
        
        [Required]
        public string Image { get; set; }
        
        public Category Category { get; set; }
        
        public DateTime CreateAt { get; set; }
    }
}