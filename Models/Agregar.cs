using System;
using System.ComponentModel.DataAnnotations;

namespace Jamui_Rantiy.Models
{
    public class Agregar
    {

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        [Display(Name="Descripción")]
        public String Message { get; set; }

        [Required(ErrorMessage = "Por favor ingrese la imagen")]
        [Display(Name="Imagen")]
        public String img { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un precio")]
        [Display(Name="Precio")]
        public String  Number { get; set; }

        public String Acccion { get; set; }

        public String Response { get; set; }

    }
}