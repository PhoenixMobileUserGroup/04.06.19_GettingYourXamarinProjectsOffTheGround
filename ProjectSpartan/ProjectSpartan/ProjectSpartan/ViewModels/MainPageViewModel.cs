using ProjectSpartan.Framework.Contracts;
using ProjectSpartan.Framework.UI;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectSpartan.UI.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public ICommand NavigateTappedCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "Welcome to Xamarin.Forms";
            NavigateTappedCommand = new Command(NavigateTapped);
        }

        private async void NavigateTapped()
        {
            await _navigationService.NavigateToAsync<MainPageViewModel>();
        }
    }
}
