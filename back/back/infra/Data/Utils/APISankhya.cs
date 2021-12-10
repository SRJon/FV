using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace back.infra.Data.Utils
{
    public static class APISankhya
    {
        public static async Task<string> SankhyaCRUDPostAsync(string json)
        {
            var login = await SankhyaLoginAsync();
            HttpResponseMessage response;
            string resposeContent = "";
            using (HttpClient client = login)
            {
                string url = "http://10.200.200.1:8080/mge/service.sbr?serviceName=CRUDServiceProvider.saveRecord&outputType=json";
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync(url, httpContent);
            }
            if (response != null)
            {
                resposeContent = await response.Content.ReadAsStringAsync();
            }
            return resposeContent;
        }

        public static async Task<HttpClient> SankhyaLoginAsync()
        {
            HttpResponseMessage response;
            string resposeContent = "";
            string json = "{\"serviceName\": \"MobileLoginSP.login\",\"requestBody\": {\"NOMUSU\": {\"$\": \"sup\"},\"INTERNO\": {\"$\": \"Ti@123#321\"},\"KEEPCONNECTED\": {\"$\": \"S\"}}}";
            HttpClient client = new HttpClient();
            string url = "http://10.200.200.1:8080/mge/service.sbr?serviceName=MobileLoginSP.login&outputType=json";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            response = await client.PostAsync(url, httpContent);
            if (response != null)
            {
                resposeContent = await response.Content.ReadAsStringAsync();
            }
            return client;
        }
    }
}