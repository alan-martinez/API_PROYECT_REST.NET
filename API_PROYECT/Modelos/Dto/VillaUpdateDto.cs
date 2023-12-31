﻿using System.ComponentModel.DataAnnotations;

namespace API_PROYECT.Modelos.Dto
{
    public class VillaUpdateDto
    {
        // Propiedades que se van a mostrar cuando exponga los datos
        [Required]
        public int Id { get; set; }

        [Required] //DataAnnotations
        [MaxLength(30)]
        public string Nombre { get; set; }

        public string Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; }

        [Required]
        public int Ocupantes { get; set; }

        [Required]
        public int MetrosCuadrados { get; set; }

        [Required]
        public string ImagenUrl { get; set; }

        public string Amenidad { get; set; }
    }
}
