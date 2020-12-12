using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jamui_Rantiy.Models
{
    [Table("")]
    public class Agregar
    {

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        [Display(Name="Descripción")]
        [Column("Message")]

        public String Message { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un precio")]
        [Display(Name="Precio")]
        [Column("Precio")]
      
        public float  Precio { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }


        public String Acccion { get; set; }

        public String Response { get; set; }

    }
}