using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using WebAppSchedule.Validators;

namespace WebAppSchedule.Models
{
    [Validator(typeof(Stage2Validator))]
    public class Stage2
    {
        [MinLength(1, ErrorMessage = "At Least 1 Number / Letter Is Required")]
        [Display(Name = "Customer ID", Description = "Customer ID")]
        public string CustomerID { get; set; }
        
        //calendar:           
        [UIHint("DateTime", "HTML")]
        [Display(Name = "Event Date", Description = "Event Date")]
        public DateTime EventDate { get; set; }
        
        [MinLength(2, ErrorMessage = "At Least 2 Letters Are Required")]
        [Display(Name = "Surname", Description = "Surname")]
        public string Surname { get; set; }
        
        [MinLength(15, ErrorMessage = "At Least 15 Letters Are Required")]
        [Display(Name = "Address", Description = "Address")]
        public string Address { get; set; }
        
        [MinLength(11, ErrorMessage = "At Least 11 Numbers Are Required")]
        [Display(Name = "Mobile Number", Description = "Mobile Number")]
        public string MobileNumber { get; set; }

        [MinLength(5, ErrorMessage = "At Least 5 Numbers / Letters Are Required")]
        [Display(Name = "Email", Description = "Email")]
        public string Email { get; set; }  
    }
}