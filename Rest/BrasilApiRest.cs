using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest;

public class BrasilApiRest : IBrasilApi
{
    public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
        var response = new ResponseGenerico<EnderecoModel>();

        using (var httpClient = new HttpClient())
        {
            var responseBrasilApi = await httpClient.SendAsync(request);
            var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
            var objectResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objectResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }

        return response;
    }

    public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodoOsBancos()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");
        var response = new ResponseGenerico<List<BancoModel>>();

        using (var httpClient = new HttpClient())
        {
            var responseBrasilApi = await httpClient.SendAsync(request);
            var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
            var objectResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objectResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }

        return response;
    }

    public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
        var response = new ResponseGenerico<BancoModel>();

        using (var httpClient = new HttpClient())
        {
            var responseBrasilApi = await httpClient.SendAsync(request);
            var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
            var objectResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objectResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }

        return response;
    }
}
