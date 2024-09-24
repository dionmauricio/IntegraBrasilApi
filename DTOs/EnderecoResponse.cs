using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs;

public class EnderecoResponse
{
    public string Cep { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set; } = string.Empty;

    [JsonIgnore]
    public string Servico { get; set; } = string.Empty;
}
