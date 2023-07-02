using System.ComponentModel.DataAnnotations;

namespace API_PROYECT.Modelos.Dto
{
    public class VillaDto
    {
        // Propiedades que se van a mostrar cuando exponga los datos
        public int Id { get; set; }

        [Required] //DataAnnotations
        [MaxLength(30)]
        public string Nombre { get; set; }
    }
}
