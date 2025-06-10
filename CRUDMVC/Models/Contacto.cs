using System.ComponentModel.DataAnnotations;

namespace CRUDMVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
