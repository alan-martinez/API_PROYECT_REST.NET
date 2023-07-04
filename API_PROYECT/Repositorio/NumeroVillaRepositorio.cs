using API_PROYECT.Datos;
using API_PROYECT.Modelos;
using API_PROYECT.Repositorio.IRepositorio;

namespace API_PROYECT.Repositorio
{
    //Hereda todos los metodos de repositorio generico
    public class NumeroVillaRepositorio : Repositorio<NumeroVilla>, INumeroVillaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public NumeroVillaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<NumeroVilla> Actualizar(NumeroVilla entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.NumeroVillas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
