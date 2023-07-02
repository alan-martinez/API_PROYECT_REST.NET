using API_PROYECT.Modelos.Dto;

namespace API_PROYECT.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id = 1, Nombre = "Casa vista a la piscina", Ocupantes=3, MetrosCuadrados=50},
            new VillaDto{Id = 2, Nombre = "Vista casa a la playa", Ocupantes=4, MetrosCuadrados=80}
        };
    }
}
