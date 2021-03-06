﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Required(ErrorMessage = "Ingrese Su Nombre Completo")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Necesitamos La Provincia")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Necesitamos La Ciudad")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Necesitamos la Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La  cedula es obligatoria")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }
        public DateTime FecaNac { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal SueldoFijo { get; set; }
    }
}
