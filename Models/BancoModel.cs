using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? NomeAbreviado { get; set; }

        [JsonPropertyName("code")]
        public string? Codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }
        
    }
}