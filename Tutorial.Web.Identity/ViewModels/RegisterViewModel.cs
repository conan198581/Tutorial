﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Web.Identity.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="用户名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name ="密 码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
