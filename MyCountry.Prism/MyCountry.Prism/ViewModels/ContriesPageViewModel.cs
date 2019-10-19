using MyCountry.Common.Model;
using MyCountry.Common.Services;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace MyCountry.Prism.ViewModels
{
    public class ContriesPageViewModel : ViewModelBase
    {

        private ObservableCollection<CountryResponse> _countries;
        private INavigationService _navigationService;
        private IApiService _apiService;

        public ContriesPageViewModel(
            INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            Title = "Countries";
            _navigationService = navigationService;
            _apiService = apiService;
            ViewCountriesAsync();
        }

        public ObservableCollection<CountryResponse> Countries
        {
            get => _countries;
            set => SetProperty(ref _countries, value);
        }

        public async void ViewCountriesAsync()
        {
            var url = App.Current.Resources["UrlAPI"].ToString();

            var response = await _apiService.GetListAsync<CountryResponse>(
            url,
            "/rest",
            "/v2/all");

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error", "check data entry", "accept");
                return;
            }

            Countries = new ObservableCollection<CountryResponse>(response.Result);

        }

    }
}
