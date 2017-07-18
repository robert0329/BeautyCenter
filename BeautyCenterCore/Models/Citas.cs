using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Necesitamos el nombre del cliente")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Ingrese el Servicio")]
        public string Servicio { get; set; }

        [Required(ErrorMessage = "Ingrese La cantidad de personas")]
        public int CantPersonas { get; set; }

        [Required(ErrorMessage = "La fecha es Obligatorio")]
        public DateTime Fecha { get; set; }
    }
}
