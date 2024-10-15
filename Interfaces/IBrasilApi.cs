

using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosOsBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}