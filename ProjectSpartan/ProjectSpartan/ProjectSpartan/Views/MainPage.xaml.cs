using ProjectSpartan.UI.ViewModels;

namespace ProjectSpartan.UI.Views
{
    public partial class MainPage : BaseView
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
