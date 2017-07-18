using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
    }
}
