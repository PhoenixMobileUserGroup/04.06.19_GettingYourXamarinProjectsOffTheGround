using ProjectSpartan.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpartan.UI.Navigation.Contracts
{
    public interface INavigationService
    {
        void InitializeNavigation<TViewModel>() where TViewModel : BaseViewModel;
        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel;
        Task BackAsync();
    }
}
