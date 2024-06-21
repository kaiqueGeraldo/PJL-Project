using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PJL_Project.Models;
using PJL_Project.Services;

namespace PJL_Project.ViewModels
{
    public partial class SignUpViewModel : ObservableObject
    {
        private readonly ApiService _apiService;

        public SignUpViewModel()
        {
            _apiService = new ApiService();
        }

        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _senha;

        [ObservableProperty]
        private Usuario _usuario;

        [RelayCommand]
        public async Task Cadastrar()
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
