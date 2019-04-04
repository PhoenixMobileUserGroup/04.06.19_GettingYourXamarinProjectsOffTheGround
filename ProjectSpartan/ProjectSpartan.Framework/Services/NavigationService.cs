using ProjectSpartan.Framework.Contracts;
using ProjectSpartan.Framework.UI;
using System;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectSpartan.Framework.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IDependencyResolutionService _dependencyResolutionService;

        public NavigationService(IDependencyResolutionService dependencyResolutionService)
        {
            _dependencyResolutionService = dependencyResolutionService;
        }

        public void InitializeNavigation<TViewModel>() where TViewModel : BaseViewModel
        {
            Page page = CreatePage(typeof(TViewModel), null);
            Application.Current.MainPage = new NavigationPage(page);
        }

        public async Task BackAsync()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel
        {
            return InternalNavigateToAsync(typeof(TViewModel), null);
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel
        {
            return InternalNavigateToAsync(typeof(TViewModel), parameter);
        }

        private async Task InternalNavigateToAsync(Type viewModelType, object parameter)
        {
            Page page = CreatePage(viewModelType, parameter);

            if (Application.Current.MainPage == null)
            {
                Application.Current.MainPage = new NavigationPage(page);
            }
            else
            {
                await Application.Current.MainPage.Navigation.PushAsync(page);
            }

            await (page.BindingContext as BaseViewModel).InitializeAsync(parameter);
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            var viewName = viewModelType.FullName.Replace("Model", string.Empty);
            var viewModelAssemblyName = viewModelType.GetTypeInfo().Assembly.FullName;
            var viewAssemblyName = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);
            var viewType = Type.GetType(viewAssemblyName);
            return viewType;
        }

        private Page CreatePage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);
            if (pageType == null)
            {
                throw new Exception($"Cannot locate page type for {viewModelType}");
            }

            Page page = _dependencyResolutionService.GetInstance(pageType) as Page;
            return page;
        }
    }
}
