using Prism.Navigation;

namespace MyCountry.Prism.ViewModels
{
    public class ContriesPageViewModel : ViewModelBase
    {
        public ContriesPageViewModel(
            INavigationService navigationService) : base(navigationService)
        {
            Title = "Countries";
        }
    }
}
