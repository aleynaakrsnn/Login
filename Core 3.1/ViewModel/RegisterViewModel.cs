﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SLE_System.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
         
        [DataType(DataType.Password)]
        [Display(Name ="TEKRAR Password")]
        [Compare("Password",ErrorMessage ="PaSSWORD EŞLEŞMİYOR.")]
        public string ConfirmPassword { get; set; }
    }
}
