using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class Provincias
    {
        [Key]
        public int ProvinciaId { get; set; }
        public int CiudadId { get; set; }
        public string NombreProv { get; set; }
    }
}
