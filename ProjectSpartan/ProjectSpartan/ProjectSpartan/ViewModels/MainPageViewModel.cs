using ProjectSpartan.Framework.Contracts;
using ProjectSpartan.Framework.UI;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectSpartan.UI.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public ICommand NavigateTappedCommand { get; private set; }

        public string Message { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "Welcome to Xamarin.Forms";
            NavigateTappedCommand = new Command(NavigateTapped);
        }

        public override Task InitializeAsync(object navigationalParameter)
        {
            if (navigationalParameter != null)
                Message = navigationalParameter as string;

            return base.InitializeAsync(navigationalParameter);
        }

        private async void NavigateTapped()
        {
            await _navigationService.NavigateToAsync<MainPageViewModel>("hi");
        }
    }
}
