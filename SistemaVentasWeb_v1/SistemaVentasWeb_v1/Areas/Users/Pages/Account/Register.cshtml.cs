using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;//cargamos la libreria para IFormFile para cargar archivos.
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaVentasWeb_v1.Areas.Users.Models;//agregamos el using donde se encuentra la clase a heredar

namespace SistemaVentasWeb_v1.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]//creamos una propiedad de la clase InputModel para poder tener acceso a los
        //elementos de la clase InputModel, con acceso desde la interfaz de usuario
        public InputModel Input { get; set; }
        //creamos una nueva clase para heredar las propiedades
        public class InputModel : InputModelRegister
        { 
            public IFormFile AvatarImage { get; set; }//sera una propiedad de la interface para el formulario de registro
            [TempData]
            public string ErrorMessage { get; set; }
        }
    }
}
