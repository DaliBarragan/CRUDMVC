using Microsoft.EntityFrameworkCore;

namespace CRUDMVC.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                        
        }
        
        //AGREGAR MODELOS AQUI
    }
}
