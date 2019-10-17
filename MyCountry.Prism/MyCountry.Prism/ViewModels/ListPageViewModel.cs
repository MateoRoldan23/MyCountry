using MyCountry.Common.Services;
using Prism.Commands;
using Prism.Navigation;

namespace MyCountry.Prism.ViewModels
{
    public class ListPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private DelegateCommand _listCommand;
        private bool _isEnabled;
        private bool _isRunning;

        public ListPageViewModel(
            INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title = "List of Contries";
            IsEnabled = true;
        }

        public DelegateCommand ListCommand => _listCommand ?? (_listCommand = new DelegateCommand(list));


        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }


        private async void list()
        {
            IsRunning = true;
            IsEnabled = false;

            await _navigationService.NavigateAsync("ContriesPage");

            IsRunning = false;
            IsEnabled = true;

        }
    }
}



