using AutoMapper;
using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mappings
{
    public class EnderecoMapping: Profile
    {
        public EnderecoMapping(){
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
        
    }
}