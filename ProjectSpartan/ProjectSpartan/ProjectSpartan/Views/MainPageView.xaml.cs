using ProjectSpartan.UI.ViewModels;

namespace ProjectSpartan.UI.Views
{
    public partial class MainPageView : BaseView
    {
        public MainPageView(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }
    }
}
