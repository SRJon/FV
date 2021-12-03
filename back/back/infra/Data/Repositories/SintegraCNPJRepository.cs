using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using back.data.entities.SintegraCNPJQuery;
using back.domain.Repositories;
using back.infra.Data.Context;
using Newtonsoft.Json;

namespace back.infra.Data.Repositories
{
    public class SintegraCNPJRepository : ISintegraCNPJRepository
    {
        private readonly DbContexts _ctxs;

        public SintegraCNPJRepository(DbContexts ctxs) : base()
        {
            _ctxs = ctxs;
        }

        public SintegraCNPJ consultaCNPJSintegraWS(string numero_cpfCnpj)
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
                    try
                    {
                        cnpj = Newtonsoft.Json.JsonConvert.DeserializeObject<SintegraCNPJ>(jsonRetorno);
                    }
                    catch (System.Exception)
                    {
                        return null;
                    }
                }
            }
            return cnpj;
        }
    }
}