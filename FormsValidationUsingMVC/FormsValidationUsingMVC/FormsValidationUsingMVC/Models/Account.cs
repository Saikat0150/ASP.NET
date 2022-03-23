using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormsValidationUsingMVC.Models
{
    
        public class Account
        {
            [Required]
            [MinLength(3)]
            [MaxLength(10)]
            public string Username
            {
                get;
                set;
            }

            [Required]
            [MinLength(3)]
            [MaxLength(10)]
            [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
            public string Password
            {
                get;
                set;
            }

            [Required]
            public string FullName
            {
                get;
                set;
            }

            [Required]
            [Range(18, 50)]
            public int Age
            {
                get;
                set;
            }

            [Required]
            [EmailAddress]
            public string Email
            {
                get;
                set;
            }

            [Url]
            public string Website
            {
                get;
                set;
            }

        }
    }