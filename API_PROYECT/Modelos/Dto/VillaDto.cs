﻿using System.ComponentModel.DataAnnotations;

namespace API_PROYECT.Modelos.Dto
{
    public class VillaDto
    {
        // Propiedades que se van a mostrar cuando exponga los datos
        public int Id { get; set; }

        [Required] //DataAnnotations
        [MaxLength(30)]
        public string Nombre { get; set; }

        public string Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public int MetrosCuadrados { get; set; }

        public string ImagenUrl { get; set; }

        public string Amenidad { get; set; }
    }
}
