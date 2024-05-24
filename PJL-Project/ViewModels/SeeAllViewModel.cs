using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PJL_Project.ViewModels
{
    public partial class SeeAllViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task BackPage()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
