using System.Net;
using IntegracaoBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly EnderecoService _enderecoService;

        public EnderecoController(EnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public async Task<ActionResult> BuscarEndereco([FromRoute] string cep){
            var response = await _enderecoService.BuscarEndereco(cep);
            if(response.CodigoHttp == HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}