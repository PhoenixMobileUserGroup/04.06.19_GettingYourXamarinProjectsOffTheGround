using ProjectSpartan.Framework.Contracts;
using ProjectSpartan.UI.StartUp;
using ProjectSpartan.UI.ViewModels;
using ProjectSpartan.UI.Views;
using SimpleInjector;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjectSpartan.UI
{
    public partial class App : Application
    {
        private Container Container { get; set; }

        public App()
        {
            InitializeComponent();
            Container = IOCConfiguration.GetRegisteredContainer();

            var navigationService = Container.GetInstance<INavigationService>();
            navigationService.InitializeNavigation<MainPageViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
