using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class Servicios
    {
        [Key]
        public int ServicioId { get; set; }

        [Required(ErrorMessage = "Nombre del Servicio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio y de suma importancia")]
        public decimal Costo { get; set; }
    }
}
