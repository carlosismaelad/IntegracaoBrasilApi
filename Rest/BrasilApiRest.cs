using System.Dynamic;
using System.Text.Json;
using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResponse);

                if(responseBrasilApi.IsSuccessStatusCode){
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else{
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodosOsBancos()
        {
            throw new NotImplementedException();
        }
        public Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }        
    }
}