using MyCountry.Common.Model;
using Prism.Navigation;

namespace MyCountry.Prism.ViewModels
{
    public class ContriesPageViewModel : ViewModelBase
    {
        private Country _country;

        public ContriesPageViewModel(
            INavigationService navigationService) : base(navigationService)
        {
            Title = "Countries";
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);

            if(parameters.ContainsKey("Country"))
            {
                _country = parameters.GetValue<Country>("Country");
            }
        }
    }
}
