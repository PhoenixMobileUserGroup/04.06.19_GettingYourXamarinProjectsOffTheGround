using PropertyChanged;
using System.Threading.Tasks;

namespace ProjectSpartan.Framework.UI
{
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseViewModel
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }
        public Task OnAppearing() { return Task.CompletedTask; }
        public Task OnDisappearing() { return Task.CompletedTask; }
        public virtual Task InitializeAsync(object navigationalParameter)
        {
            return Task.FromResult(false);
        }
    }
}
