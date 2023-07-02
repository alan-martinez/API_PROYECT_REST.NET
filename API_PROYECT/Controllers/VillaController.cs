using API_PROYECT.Datos;
using API_PROYECT.Modelos;
using API_PROYECT.Modelos.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PROYECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        //endpoint retorna todas las villas
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)] //Documentar diferentes codigos de estado
        //ActionResult -> para trabajar con codigos de estado
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            return Ok (VillaStore.villaList);
        }

        //Endpoint que retorne una sola villa
        [HttpGet("id:int", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)] //Documentar diferentes codigos de estado
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }

        [HttpPost] //Endpoint para crear nueva villa
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDto> CrearVilla([FromBody] VillaDto villaDto) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //Validacion personalizada
            if (VillaStore.villaList.FirstOrDefault(v => v.Nombre.ToLower() == villaDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "La villa con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (villaDto == null)
            {
                return BadRequest(villaDto);
            }
            if (villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            //Grabar el siguiente ID
            villaDto.Id = VillaStore.villaList.OrderByDescending(v => v.Id).FirstOrDefault().Id +1;
            VillaStore.villaList.Add(villaDto);

            return CreatedAtRoute("GetVilla", new { id = villaDto.Id }, villaDto); //Redirigir a una ruta
        }
    }
}
