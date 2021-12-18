using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace productsCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}
        [Required]
        public string CategoryName {get;set;}
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Association> ProductList {get;set;}

    }
}