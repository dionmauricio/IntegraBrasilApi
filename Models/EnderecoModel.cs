using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models;

public class EnderecoModel
{
    [JsonPropertyName("cep")]
    public string Cep { get; set; } = string.Empty;

    [JsonPropertyName("state")]
    public string Estado { get; set; } = string.Empty;

    [JsonPropertyName("city")]
    public string Cidade { get; set; } = string.Empty;

    [JsonPropertyName("neighborhood")]
    public string Bairro { get; set; } = string.Empty;

    [JsonPropertyName("street")]
    public string Rua { get; set; } = string.Empty;

    [JsonPropertyName("service")]
    public string Servico { get; set; } = string.Empty;
}
