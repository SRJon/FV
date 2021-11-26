using System.Threading.Tasks;
using back.data.entities.SintegraCNPJQuery;

namespace back.domain.Repositories
{
    public interface ISintegraCNPJRepository
    {
        public SintegraCNPJ consultaCNPJSintegraWS(string numero_cpf);
    }
}