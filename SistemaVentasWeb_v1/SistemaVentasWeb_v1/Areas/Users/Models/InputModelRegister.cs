using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasWeb_v1.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "El campo ID es obligatorio.")]
        public string NID { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [DataType(DataType.PhoneNumber)]//que tipo de dato se va almacenar en la variable
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$",ErrorMessage ="El formato telefono ingresado no es valido.")]
        //expersion regular que dara el formato al numero de telefono que sera ingresado en la variable
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo correo electronico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El dato ingresado no es una direccion de correo electronico valido.")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]//clase display para poder cambiar el nombre de la propiedad, para no visualizar el nombre real en el lado del cliente
        [Required(ErrorMessage = "El campo contraseña es obligatorio.")]
        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        //canidad maxima de caracteres (100) con cantidad minima 6
        public string Password { get; set; }
    }
}
