using MyCountry.Common.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MyCountry.Common.Services
{
    public interface IApiService
    {
        Task<Response<ObservableCollection<CountryResponse>>> GetListAsync(string urlBase, string servicePrefix, string controller);
    }
}