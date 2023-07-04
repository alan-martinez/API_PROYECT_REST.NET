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
        public DbSet<NumeroVilla> NumeroVillas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Cuando se ejecuta por primera vez la aplicacion -> se crean estos registro en la BD
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la villa",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa vista a la playa",
                    Detalle = "Detalle de la villa",
                    ImagenUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrados = 80,
                    Tarifa = 500,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
                );
        }
    }
}
