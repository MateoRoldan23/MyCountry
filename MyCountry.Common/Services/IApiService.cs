using System.Threading.Tasks;
using MyCountry.Common.Model;

namespace MyCountry.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}