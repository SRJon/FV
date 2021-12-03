using System.Net.Http;
using System.Threading.Tasks;
using back.data.entities.SintegraCNPJQuery;
using back.infra.Data.Context;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace back.infra.Services.SintegraCNPJServices
{
    public static class ConsultaCNPJService
    {
        public static SintegraCNPJ GetByIdService(this DbAppContextFVUDB_TESTE ctx, string numero_cpfCnpj)
        {
            SintegraCNPJ cnpj = new SintegraCNPJ();
            using (HttpClient client = new HttpClient())
            {
                string url = "https://www.receitaws.com.br/v1/cnpj/" + numero_cpfCnpj;
                var response = client.GetAsync(url).Result;
                using (HttpContent content = response.Content)
                {
                    var result = content.ReadAsStringAsync();
                    string jsonRetorno = result.Result;
                    cnpj = JsonSerializer.Deserialize<SintegraCNPJ>(jsonRetorno);
                }
            }
            return cnpj;
        }

    }
}