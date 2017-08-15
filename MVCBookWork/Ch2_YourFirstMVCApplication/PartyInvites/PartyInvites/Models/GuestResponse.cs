using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        // question mark symbolizes a nullable bool... 
        // means that it can be true, false, or null
        // a nullable bool is necessary so that a null value can be accepted by the "WillAttend" property
        // since a nullable bool has three possible values (true, false, and null),... null is used whenever a value 
        // isn't selected... this way it is known if a value is selected or not. 
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}