using API_PROYECT.Modelos;
using Microsoft.EntityFrameworkCore;

namespace API_PROYECT.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
