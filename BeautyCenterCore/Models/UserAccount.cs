using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyCenterCore.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Primer Nombre es requerido.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Apellido es Requerido.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email es Requerido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Usuario es Requerido")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "No coinciden las contraseñas")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
