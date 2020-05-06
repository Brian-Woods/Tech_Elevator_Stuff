using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Compare("Email", ErrorMessage = "Email does not match")]
        public string EmailMatcher { get; set; }

        [Required, MinLength(8), DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Password does not match")]
        public string PasswordMatcher { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        public int NumTickets { get; set; }
    }
}