using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TestBackEndApi.Api.ViewModels;
using TestBackEndApi.Domain.Queries.Cep.Get;

namespace TestBackEndApi.Api.Controllers
{
    [Route("api/cep")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CepController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("json")]
        public async Task<IActionResult> GetJson([FromQuery] GetCepQuery query)
        {
            try
            {
                var response = await _mediator.Send(query);

                if (response == null)
                    return NotFound();

                // Reorganização de código.
                if (string.IsNullOrEmpty(response.Cep))
                    return BadRequest(response);

                return Ok(new CepResultViewModel
                {
                    Cep = response.Cep,
                    Logradouro = response.Logradouro,
                    Complemento = response.Complemento,
                    Bairro = response.Bairro,
                    Localidade = response.Localidade,
                    Mensagens = response.Mensagens
                });
            }
            catch (Exception)
            {
                return StatusCode(500, "Um erro interno ocorreu, por favor tente novamente.");
            }
        }

        [HttpGet]
        [Produces("application/xml")]
        [Route("xml")]
        public async Task<IActionResult> GetXml([FromQuery] GetCepQuery query)
        {
            try
            {
                var response = await _mediator.Send(query);

                if (response == null)
                    return NotFound();

                // Reorganização de código.
                if (string.IsNullOrEmpty(response.Cep))
                    return BadRequest(response);

                return Ok(new CepResultViewModel
                {
                    Cep = response.Cep,
                    Logradouro = response.Logradouro,
                    Complemento = response.Complemento,
                    Bairro = response.Bairro,
                    Localidade = response.Localidade,
                    Mensagens = response.Mensagens
                });
            }
            catch (Exception)
            {
                return StatusCode(500, "Um erro interno ocorreu, por favor tente novamente.");
            }
        }
    }
}
