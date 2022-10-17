using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityManagement_dotnet5.Repos
{
    public interface IRepos<T1, T2> where T1 : class
    {
        Task<IEnumerable<T1>> GetAll();
        Task<T1> GetById(T2 id);
    }
}
