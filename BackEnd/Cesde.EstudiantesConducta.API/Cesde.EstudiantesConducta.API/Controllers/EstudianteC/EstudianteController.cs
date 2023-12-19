using CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC;
using CESDE.ConductaEstudiante.Application.Queries.ConductaEstudianteQ;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cesde.EstudiantesConducta.API.Controllers.EstudianteC
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        private readonly IMediator _mediator;


        public EstudianteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CrearConductaEstudiante")]

        public async Task<IActionResult> CrearConductaEstudiante(CrearConductaEstudianteCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                throw new Exception("Error", e);
            }
        }

        [HttpPut]
        [Route("EditarConductaEstudiante")]

        public async Task<IActionResult> EditarConductaEstudiante(EditarConductaEstudianteCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                throw new Exception("Error", e);
            }
        }


        [HttpDelete]
        [Route("EliminarConductaEstudiante/{Id}")]

        public async Task<IActionResult> EliminarConductaEstudiante(int Id)
        {

            try
            {
                var result = await _mediator.Send(new EliminarConductaEstudiante { Id = Id });

                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                throw new Exception("Error" + e);
            }
        }


        [HttpGet]
        [Route("ConsultarConductasEstudiantes")]

        public async Task<IActionResult> ConsultarConductasEstudiantes()
        {

            try
            {
                var result = await _mediator.Send(new ConductaEstudianteQuery());

                return Ok(result);
            }
            catch (Exception e)
            {

                throw new Exception("Error" + e);
            }
        }
    }
}


