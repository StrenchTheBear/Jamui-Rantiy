using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jamui_Rantiy.Models
{
    [Table("t_editar")]
    public class Editar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        [Column("name")]
        public String Name { get; set; }    

        [Column("image_name")]
        public String ImagenName { get; set; }

        [Display(Name="Precio")]
        [Column("price")]
        public Decimal Price { get; set; }
    }
}