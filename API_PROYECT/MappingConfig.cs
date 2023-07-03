using API_PROYECT.Modelos;
using API_PROYECT.Modelos.Dto;
using AutoMapper;

namespace API_PROYECT
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>(); //Fuente: Villa, Destino: VillaDto 
            CreateMap<VillaDto, Villa>(); //Fuente: VillaDto, Destino: Villa 

            CreateMap<Villa, VillaCreateDto>().ReverseMap(); //Fuente: Ambas, Destino: Ambas 
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();
        }
    }
}
