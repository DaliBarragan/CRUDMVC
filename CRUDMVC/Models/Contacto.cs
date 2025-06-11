using System.ComponentModel.DataAnnotations;

namespace CRUDMVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Telefono es Obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Email es Obligatorio")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }

    }
}
