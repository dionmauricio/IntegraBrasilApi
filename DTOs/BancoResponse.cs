namespace IntegraBrasilApi.DTOs;

public class BancoResponse
{
    public string Ispb { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public int? Codigo { get; set; }
    public string NomeCompleto { get; set; } = string.Empty;
}
