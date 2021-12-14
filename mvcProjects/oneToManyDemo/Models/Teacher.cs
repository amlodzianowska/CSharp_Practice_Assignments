using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oneToManyDemo.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Course {get;set;}
        public List<Student> MyStudents {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}