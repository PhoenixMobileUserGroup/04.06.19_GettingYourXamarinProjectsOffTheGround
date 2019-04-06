using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpartan.UI.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseViewModel
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }
        public Task OnAppearing() => Task.CompletedTask;
        public Task OnDisappearing() => Task.CompletedTask;
        public Task InitializeAsync(object navigationalParameter) => Task.CompletedTask;
    }
}