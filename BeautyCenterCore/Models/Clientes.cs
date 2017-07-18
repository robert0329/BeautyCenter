using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class Clientes
    {
        [Key]
        public int    ClienteId { get; set; }

        [Required(ErrorMessage = "Ingrese Su Nombre Completo")]
        public string Nombres { get; set; }
        
        public string Provincia { get; set; }
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Necesitamos la Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La  cedula es obligatoria")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }

        public DateTime FechaNac { get; set; }
    }
}
