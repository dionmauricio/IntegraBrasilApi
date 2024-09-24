using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models;

public class BancoModel
{
    [JsonPropertyName("ispb")]
    public string Ispb { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Nome { get; set; } = string.Empty;

    [JsonPropertyName("code")]
    public int? Codigo { get; set; }

    [JsonPropertyName("fullName")]
    public string NomeCompleto { get; set; } = string.Empty;
}
