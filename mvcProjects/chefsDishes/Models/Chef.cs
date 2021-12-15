using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace chefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        public string FName {get;set;}
        [Required]
        public string LName {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday {get;set;}
        public List<Dish> MyDishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}