using ProjectSpartan.UI.ViewModels;
using System;
using Xamarin.Forms;

namespace ProjectSpartan.UI.Views
{
    public partial class BaseView : ContentPage
    {
        public bool HasAppeared { get; set; }

        public BaseView()
        {
            InitializeComponent();
        }

        private async void OnAppearing(object sender, EventArgs e)
        {
            if(!HasAppeared)
                Title = (BindingContext as BaseViewModel).Title;

            await (BindingContext as BaseViewModel)?.OnAppearing();
        }

        private async void OnDisappearing(object sender, EventArgs e)
        {
            await (BindingContext as BaseViewModel)?.OnDisappearing();
        }
    }
}