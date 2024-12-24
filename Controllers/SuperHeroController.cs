using FinalSuperHeroes.Models;
using Microsoft.AspNetCore.Mvc;
using Superheroes.Factory;
using Superheroes.Interfaces;
using Superheroes.Requests;

namespace Superheroes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpPost("CrearSuperHeroe")]
        public IActionResult CrearSuperHeroe([FromBody] CrearSuperheroeRequest request)
        {
            if (request == null)
            {
                return BadRequest("Faltan los datos, por favor completa todos los campos.");
            }

            if (string.IsNullOrEmpty(request.Nombre))
            {
                return BadRequest("Ponele un nombre, vamos!");
            }

            if (string.IsNullOrEmpty(request.Tipo))
            {
                return BadRequest("Tenes que completar el tipo, dale!");
            }

            try
            {
                ISuperheroe superheroe = SuperHeroFactory.CrearSuperHeroe(request.Nombre, request.Tipo);
                return Ok(superheroe);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Enfermeria")]
        public ActionResult VisitarEnfermeria([FromBody] VisitarEnfermeriaRequest request)
        {
            if (request == null)
            {
                return BadRequest("Faltan los datos, por favor completa todos los campos!");
            }

            if (request.CantidadVisitas < 1 || request.CantidadVisitas > 5)
            {
                return BadRequest("La cantidad no puede ser mayor a 5");
            }

            if (request.SaludActual < 0 || request.SaludActual > 5)
            {
                return BadRequest("La salud tiene que estar entre 0 y 5");
            }

            if (string.IsNullOrEmpty(request.Tipo))
            {
                return BadRequest("Pone el tipo de heroe, dale!");
            }

            var tiposValidos = new[] { "archer", "wizard", "warrior" };
            if (!tiposValidos.Contains(request.Tipo.ToLower()))
            {
                return BadRequest($"Mmm ese heroe no existe! Te recuerdo los tipos permitidos: {string.Join(", ", tiposValidos)}.");
            }

            var enfermeria = Enfermeria.ObtenerInstancia();
            int saludModificada = request.SaludActual;
            bool atencion = enfermeria.VisitarEnfermeria(ref saludModificada, request.CantidadVisitas);

            if (atencion)
            {
                return Ok(new
                {
                    Salud = saludModificada,
                    AtencionesRestantes = enfermeria.GetAtencionesRestantes()
                });
            }
            else
            {
                return BadRequest("Ya no hay más visitas disponibles :(");
            }
        }
    }
}
