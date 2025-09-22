using BlazorApp1.DATA;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlojamController : ControllerBase
    {
        private readonly IAlojamientoService _alojamService;

        public AlojamController(IAlojamientoService alojamService)
        {
            _alojamService = alojamService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alojam>>> getAllAlojam()
        {

            try
            {
                var response = await _alojamService.getAllAsync();

                if (response == null || !response.Any())
                {
                    return NotFound("no se encontro");
                }
                else
                {
                    return response;
                }

            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Error :{ex.Message}");


            }
            ;
        }

        [HttpGet("provincia/{thCod:int}")]
        public async Task<ActionResult<List<Alojam>>> GetAlojProvincia(int thCod)
        {
            try
            {
                var response = await _alojamService.getAlojProv(thCod);

                if (response == null || !response.Any())
                {
                    return NotFound($"No se encontraron alojamientos para provincia {thCod}");
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
        [HttpGet("comarca/{comCod:int}")]
        public async Task<ActionResult<List<Alojam>>> GetAlojComarca(int comCod)
        {
            try
            {
                var response = await _alojamService.getAlojComarca(comCod);

                if (response == null || !response.Any())
                {
                    return NotFound($"No se encontraron alojamientos para comarca {comCod}");
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpGet("animals/{dog:bool}")]
        public async Task<ActionResult<List<Alojam>>> GetAlojByAnimals(bool dog)
        {
            try
            {
                var response = await _alojamService.getAlojByAnimals(dog);

                if (response == null || !response.Any())
                {
                    return NotFound($"No se encontraron alojamientos con dog = {dog}");
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }



        [HttpGet("test")]
        public  IActionResult test()
        {
            return Ok("api funcionando");
        }
    }
}
