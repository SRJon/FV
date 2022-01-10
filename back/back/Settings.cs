
using back.domain.entities;
using back.domain.Enum;
using Microsoft.Extensions.Configuration;

namespace back
{
    /// <summary>
    /// TESTES
    /// </summary>
    public class Settings : DbConnection
    {
        public static string Secret = "8c9f8d8f-d8e0-4b3e-8d5b-d9e8f8d8f8d8";
        public static ConnectionEnvironment ConnectionName = ConnectionEnvironment.Development;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config">config123testando</param>
        public Settings(IConfiguration config) : base(config.GetValue<bool>("isProduction")) 
        {
       
        }

    }
}