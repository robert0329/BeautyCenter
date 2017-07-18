using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class DetalleCitas
    {
        [Key]
        public int Id { get; set; }
        public int CitaId { get; set; }

        [Required(ErrorMessage = "Ingrese EL Cliente a facturar")]
        public string Nombres { get; set; }

        public int ClienteId { get; set; }
        public string Servicio { get; set; }
    }
}
