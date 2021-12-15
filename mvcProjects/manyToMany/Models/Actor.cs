using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace manyToMany.Models
{
    public class Actor
    {
        [Key]
        public int ActorId {get;set;}
        [Required]
        public string FName {get;set;}
        [Required]
        public string LName {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Cast> ActedIn {get;set;}

    }
}