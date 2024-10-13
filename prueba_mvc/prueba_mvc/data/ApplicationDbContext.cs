using Microsoft.EntityFrameworkCore;
using prueba_mvc.Models;

namespace prueba_mvc.data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Producto>Productos { get; set; }
    }
}
