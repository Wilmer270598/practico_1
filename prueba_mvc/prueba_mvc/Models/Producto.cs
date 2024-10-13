using System.ComponentModel.DataAnnotations;

namespace prueba_mvc.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "el nombre es obligatorio")]
        [Display(Name = "nombre del producto")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "la descripcion es obligatoria")]
        public string? Descripcion{ get; set; }

    }
}
