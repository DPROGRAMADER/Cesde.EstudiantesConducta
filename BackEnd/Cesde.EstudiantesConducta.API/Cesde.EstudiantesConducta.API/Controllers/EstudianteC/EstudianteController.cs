using CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC;
using CESDE.ConductaEstudiante.Application.Queries.ConductaEstudianteQ;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        [Route("CrearConductaEstudianteCommand")]

        public async Task<IActionResult> CrearConductaEstudianteCommand(CrearConductaEstudianteCommandHanlder command)
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
        [Route("EditarConductaEstudianteCommand")]

        public async Task<IActionResult> EditarConductaEstudianteCommand(EditarConductaEstudianteCommandHanlder command)
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
        [Route("EliminarConductaEstudiante/{IdEstudiante}")]

        public async Task<IActionResult> EliminarConductaEstudiante(int IdEstudiante)
        {

            try
            {
                var result = await _mediator.Send(new EliminarConductaEstudiante { IdEstudiante = IdEstudiante });

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


