using ProjectSpartan.Framework.UI;
using System.Threading.Tasks;

namespace ProjectSpartan.Framework.Contracts
{
    public interface INavigationService
    {
        Task InitializeAsync();
        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel;
        Task RemoveLastFromBackStackAsync();
        Task RemoveBackStackAsync();
        Task BackAsync();
    }
}
