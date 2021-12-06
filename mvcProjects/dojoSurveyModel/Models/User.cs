using System;
using System.ComponentModel.DataAnnotations;

namespace dojoSurveyModel.Models
{
    public class User
    {
        // [Required(ErrorMessage ="Pet has to have a name!")]
        public string userName {get;set;}

        // [Required(ErrorMessage ="Pet must have a type!")]
        // [MinLength(2, ErrorMessage ="Pet type must contain at least 2 characters!")]
        public string location {get;set;}

        // [Required(ErrorMessage ="Pet must have an age!")]
        public string language {get;set;}

        public string comment {get;set;}

    }
}