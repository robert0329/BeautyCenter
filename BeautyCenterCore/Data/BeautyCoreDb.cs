using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeautyCenterCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BeautyCenterCore.Data;

namespace BeautyCenterCore.Models
{
    public class BeautyCoreDb : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public BeautyCoreDb() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ROBERT\\SERVER;Initial Catalog=BeautyCenter;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //Data Source=ROBERT\\SERVER;Initial Catalog=BeautyCenter;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        }


        public DbSet<BeautyCenterCore.Models.Citas> Citas { get; set; }

        public DbSet<BeautyCenterCore.Models.Clientes> Clientes { get; set; }

        public DbSet<BeautyCenterCore.Models.DetalleCitas> DetalleCitas { get; set; }

        public DbSet<BeautyCenterCore.Models.FacturaDetalles> FacturaDetalles { get; set; }

        public DbSet<BeautyCenterCore.Models.Facturas> Facturas { get; set; }

        public DbSet<BeautyCenterCore.Models.Servicios> Servicios { get; set; }

        public DbSet<BeautyCenterCore.Models.Empleados> Empleados { get; set; }

        public DbSet<BeautyCenterCore.Data.ApplicationRole> ApplicationRole { get; set; }

        public DbSet<BeautyCenterCore.Models.UserViewModel> UserViewModel { get; set; }

        public DbSet<BeautyCenterCore.Models.LoginViewModel> LoginViewModel { get; set; }
    }
}
