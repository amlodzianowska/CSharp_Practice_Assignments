using System;
using System.ComponentModel.DataAnnotations;

namespace logReg.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string lemail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string lpassword {get;set;}

    }
}