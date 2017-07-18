using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BeautyCenterCore.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }

        public ApplicationRole() { }
        public ApplicationRole(string Descripcion,DateTime CreatedDate,string IPAddress) { this.Description = Descripcion;this.CreatedDate = CreatedDate;this.IPAddress=IPAddress; }
    }
}
