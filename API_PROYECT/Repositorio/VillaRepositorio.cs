using API_PROYECT.Datos;
using API_PROYECT.Modelos;
using API_PROYECT.Repositorio.IRepositorio;

namespace API_PROYECT.Repositorio
{
    //Hereda todos los metodos de repositorio generico
    public class VillaRepositorio : Repositorio<Villa>, IVillaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public VillaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Villa> Actualizar(Villa entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.Villas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
