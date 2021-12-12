using System;
using System.ComponentModel.DataAnnotations;
namespace efDemoTwo.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId {get;set;}
        [Required]
        public string Species {get;set;}
        [Range(0,100)]
        public int numLegs {get;set;}
        public bool isMammal {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}