using System;
using System.ComponentModel.DataAnnotations;

namespace Jamui_Rantiy.Models
{
    public class Registrarse
    {
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        public String LastName { get; set; }

        [Display(Name="Email")]
        public String Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name="Telefono")]
        public int Phone { get; set; }

        public String Response { get; set; }

    }
}