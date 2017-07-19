using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeautyCenterCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BeautyCenterCore.Models
{
    public class BeautyCoreDb : DbContext
    {
        public BeautyCoreDb() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:beautycenter.database.windows.net,1433;Initial Catalog=BeautyCoreDb;Persist Security Info=False;User ID=yinetjc;Password=C@sa9797;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //Server=tcp:beautycenter.database.windows.net,1433;Initial Catalog=BeautyCoreDb;Persist Security Info=False;User ID=yinetjc;Password=C@sa9797;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        }

        public static BeautyCoreDb Create()
        {
            return new BeautyCoreDb();
        }

        
        public DbSet<UserAccount> userAccount { get; set; }
        public DbSet<BeautyCenterCore.Models.Citas> Citas { get; set; }

        public DbSet<BeautyCenterCore.Models.Clientes> Clientes { get; set; }

        public DbSet<BeautyCenterCore.Models.DetalleCitas> DetalleCitas { get; set; }

        public DbSet<BeautyCenterCore.Models.FacturaDetalles> FacturaDetalles { get; set; }

        public DbSet<BeautyCenterCore.Models.Facturas> Facturas { get; set; }

        public DbSet<BeautyCenterCore.Models.Servicios> Servicios { get; set; }

        public DbSet<BeautyCenterCore.Models.Empleados> Empleados { get; set; }
    }
}
