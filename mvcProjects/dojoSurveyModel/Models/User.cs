using System;
using System.ComponentModel.DataAnnotations;

namespace dojoSurveyModel.Models
{
    public class User
    {
        [Required(ErrorMessage ="Name required!")]
        [MinLength(2, ErrorMessage ="Username has to be at least 2 characters!")]
        public string userName {get;set;}

        [Required(ErrorMessage ="Location required!")]
        public string location {get;set;}

        [Required(ErrorMessage ="Language required!")]
        public string language {get;set;}

        [MinLength(20, ErrorMessage ="Comment has to be at least 20 characters!")]
        public string comment {get;set;}

    }
}