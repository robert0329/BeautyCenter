using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public ApplicationUser()
        {

        }
    }
}
