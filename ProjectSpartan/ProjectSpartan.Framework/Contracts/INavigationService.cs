using ProjectSpartan.Framework.UI;
using System.Threading.Tasks;

namespace ProjectSpartan.Framework.Contracts
{
    public interface INavigationService
    {
        void InitializeNavigation<TViewModel>() where TViewModel : BaseViewModel;
        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel;
        Task BackAsync();
    }
}
