using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PJL_Project.ViewModels
{
    public partial class BagViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task GoToShop()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
