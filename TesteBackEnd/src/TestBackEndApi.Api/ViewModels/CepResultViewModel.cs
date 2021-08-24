using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBackEndApi.Domain.Queries.Cep.Get;

namespace TestBackEndApi.Api.ViewModels
{
    public class CepResultViewModel
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public List<MensagemQueryResponse> Mensagens { get; set; }
    }
}
