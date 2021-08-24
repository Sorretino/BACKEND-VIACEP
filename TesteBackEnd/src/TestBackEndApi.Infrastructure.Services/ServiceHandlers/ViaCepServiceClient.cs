using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestBackEndApi.Infrastructure.Services.Contract;
using TestBackEndApi.Infrastructure.Services.Interfaces;

namespace TestBackEndApi.Infrastructure.Services.ServiceHandlers
{
    public class ViaCepServiceClient : IViaCepServiceClient
    {
        private readonly HttpClient _Client = new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") };


        public async Task<CepResponse> ObterEnderecoPorCepAsync(CepRequest cepRequest)
        {
            try
            {
                string _uri = string.Format("{0}/{1}", cepRequest.Cep, "json");
                var response = await _Client.GetAsync(_uri);

                var result = await response.Content.ReadAsStringAsync();

                //deserializar o objeto de retorno
                return JsonConvert.DeserializeObject<CepResponse>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
