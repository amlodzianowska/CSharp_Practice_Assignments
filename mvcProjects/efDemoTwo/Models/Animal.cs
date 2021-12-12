using System;
using System.ComponentModel.DataAnnotations;
namespace efDemoTwo.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId {get;set;}
        public string Species {get;set;}
        public int numLegs {get;set;}
        public bool isMammal {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}