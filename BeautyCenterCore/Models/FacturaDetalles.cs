using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class FacturaDetalles
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public string ServicioId { get; set; }
        public double Costo { get; set; }

        [Required(ErrorMessage = "El Descuento es Opcional")]
        public double Descuento { get; set; }

        public double SubTotal { get; set; }
    }
}
