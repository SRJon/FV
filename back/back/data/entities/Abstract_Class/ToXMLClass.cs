using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.Abstract_Class
{
    public abstract class ToXMLClass
    {
        public string ProductEntityToXML()

        {

            string xml = "";

            var listProperties = this.GetFieldsFromXML();

            listProperties.ForEach(x =>

            {

                xml += "<" + x.ToUpper() + "><![CDATA[" + this.GetValueByPropertyName(x, this) + "]]></" + x.ToUpper() + ">";

            });

            return xml;

        }

        public string GetValueByPropertyName<T>(string propertyName, T Context)

        {
            return Context.GetType().GetProperty(propertyName).GetValue(Context, null).ToString();
        }


        public List<string> GetFieldsFromXML(string xml = "")

        {

            var b = this.GetType().GetProperties();

            var listProperties = new List<string>();

            foreach (var i in b)

            {

                System.Console.WriteLine(i.Name);

                listProperties.Add(i.Name);



                System.Console.WriteLine(this.GetValueByPropertyName(i.Name, this));

            }

            return listProperties;

        }
    }
}