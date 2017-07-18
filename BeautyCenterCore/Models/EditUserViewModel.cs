using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class EditUserViewModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Key]
        
        [Display(Name = "Role")]
        public string ApplicationRoleId { get; set; }
        [Key]
        public List<SelectListItem> ApplicationRoles { get; set; }
        public EditUserViewModel()
        {

        }
        public EditUserViewModel(List<SelectListItem> ApplicationRoles)
        {
            this.ApplicationRoles = ApplicationRoles;
        }
    }
}
