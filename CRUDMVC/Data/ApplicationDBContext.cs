using CRUDMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVC.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                        
        }
        
        //AGREGAR MODELOS AQUI (CADA MODELO CORRESPONDE A UNA TABLA DE LA DB)
        //AGREGARLOS SINO NO SE PUEDEN HACER MIGRACIONES

        public DbSet<Contacto> Contacto { get; set; }
    }
}
