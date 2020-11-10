using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MyFirstWebsite.Models
{
    public class modelTest
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Give a name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]{1,40}\s*[a-zA-Z]{1,40}$", ErrorMessage = "Enter your name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Give an age"), Range(0,100, ErrorMessage = "Age must be between 0-100")]
        public int age { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter a Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    
    }

}