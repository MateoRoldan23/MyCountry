using MyCountry.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyCountry.Common.Services
{
    public class ApiService : IApiService
    {
        public async Task<Response<ObservableCollection<CountryResponse>>> GetListAsync(
              string urlBase,
              string servicePrefix,
              string controller)
        {
            try
            {

                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response<ObservableCollection<CountryResponse>>
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }


                var list = JsonConvert.DeserializeObject<ObservableCollection<CountryResponse>>(result);
                return new Response<ObservableCollection<CountryResponse>>
                {
                    IsSuccess = true,
                    Result = list
                };
            }
            catch (Exception ex)
            {
                return new Response<ObservableCollection<CountryResponse>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
