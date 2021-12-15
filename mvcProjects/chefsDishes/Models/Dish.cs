using System;
using System.ComponentModel.DataAnnotations;

namespace chefsDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public int Tastiness {get;set;}
        [Required]
        [Range(0,3000)]
        public int Calories {get;set;}
        [Required]
        public string Description {get;set;}
        public int ChefId {get;set;}
        public Chef MyChef {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}