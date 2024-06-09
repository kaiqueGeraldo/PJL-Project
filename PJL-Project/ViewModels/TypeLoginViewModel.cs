using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PJL_Project.ViewModels
{
    public partial class TypeLoginViewModel : ObservableObject
    {
        public TypeLoginViewModel()
        {
        }

        [RelayCommand]
        private async Task Cadastrar()
        {
            await Shell.Current.GoToAsync("SignUpPage");
        }

        [RelayCommand]
        private async Task Login()
        {
            await Shell.Current.GoToAsync("LoginPage");
        }

        [RelayCommand]
        private async Task Info()
        {
            await Shell.Current.GoToAsync("InfoPage");
        }
    }
}
