using PropertyChanged;
using System.Threading.Tasks;

namespace ProjectSpartan.UI.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseViewModel
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }
        public Task OnAppearing() { return Task.CompletedTask; }
        public Task OnDisappearing() { return Task.CompletedTask; }
    }
}


