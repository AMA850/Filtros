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
        }


        [HttpGet("test")]
        public  IActionResult test()
        {
            return Ok("api funcionando");
        }
    }
}
