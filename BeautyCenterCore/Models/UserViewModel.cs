﻿using BeautyCenterCore.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeautyCenterCore.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
       // public List<SelectListItemm> ApplicationRoles { get; set; }
        [Display(Name = "Role")]
        public string ApplicationRoleId { get; set; }

    }
}
