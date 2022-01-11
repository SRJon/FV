using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.Abstract_Class
{
    /// <summary>
    /// Classe que cria um Json usando os parametros de uma entidade
    /// </summary>
    public abstract class ToJsonClass
    {
        /// <summary>
        /// Criação do json seguindo os dados da entidade
        /// </summary>
        /// <param name="rootEntity">Nome da classe que está sendo criada, por exemplo TSICID ->Cidade</param>
        /// <returns></returns>

        public string ProductEntityToJson(string rootEntity)

        {

            string json = "{ \"serviceName\":\"CRUDServiceProvider.saveRecord\",\"requestBody\":{\"dataSet\":{\"rootEntity\":\"" + rootEntity + "\",\"includePresentationFields\":\"S\",\"dataRow\":{\"localFields\":{";
            string parameters = "";

            var listProperties = this.GetFieldsFromJson();
            try
            {
                listProperties.ForEach(x =>
             {
                 try
                 {
                     var value = this.GetValueByPropertyName(x, this);
                     if (value != null)
                     {
                         json += "\"" + x.ToUpper() + "\":{\"$\":\"" + value + "\"},";
                         parameters += x.ToUpper() + ",";
                     }
                 }
                 catch (System.Exception)
                 {
                 }

                 //não está retornando quando o campo é nullç
             });
            }
            catch (System.Exception)
            {
            }
            json = json.Substring(0, json.Length - 1);
            parameters = parameters.Substring(0, parameters.Length - 1);
            json += "}},\"entity\":{\"fieldset\":{\"list\":\"" + parameters + "\"}}}}}";
            //Retirada da ultima virgula.
            return json;

        }

        public string GetValueByPropertyName<T>(string propertyName, T Context)

        {
            return Context.GetType().GetProperty(propertyName).GetValue(Context, null).ToString();
        }


        public List<string> GetFieldsFromJson(string json = "")

        {

            var b = this.GetType().GetProperties();

            var listProperties = new List<string>();

            foreach (var i in b)

            {
                try
                {
                    System.Console.WriteLine(i.Name);
                    listProperties.Add(i.Name);
                    System.Console.WriteLine(this.GetValueByPropertyName(i.Name, this));
                }
                catch (System.Exception)
                {

                }
            }

            return listProperties;

        }

    }
}