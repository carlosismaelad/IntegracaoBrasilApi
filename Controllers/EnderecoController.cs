using System.Net;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep){
            var response = await _enderecoService.BuscarEndereco(cep);
            if(response.CodigoHttp == HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }
            else{
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}