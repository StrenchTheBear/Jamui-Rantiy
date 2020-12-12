using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jamui_Rantiy.Models
{
    [Table("t_editar")]
    public class Editar
    {

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        [Display(Name = "Descripción")]
        [Column("message")]
        public String Message { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un precio")]
        [Display(Name = "Precio")]
        [Column("price")]

        public Decimal Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }


        public String Acccion { get; set; }

        public String Response { get; set; }

    }
}