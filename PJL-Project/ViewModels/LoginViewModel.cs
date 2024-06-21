using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PJL_Project.Services;

namespace PJL_Project.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly ApiService _apiService;

        public LoginViewModel()
        {
            _apiService = new ApiService();
        }

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _senha;

        [RelayCommand]
        public async Task Entrar()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        [RelayCommand]
        public async Task Info()
        {
            await Shell.Current.GoToAsync("InfoPage");
        }
    }
}
