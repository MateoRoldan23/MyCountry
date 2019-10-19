using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MyCountry.Common.Model;

namespace MyCountry.Common.Services
{
    public interface IApiService
    {
        Task<Response<ObservableCollection<CountryResponse>>> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}