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

        [RelayCommand]
        private async Task Cadastrar()
        {
            var usuario = new Usuario
            {
                Nome = Nome,
                Email = Email,
                Senha = Senha
            };

            bool success = await _apiService.PostUsuario(usuario);

            if (success)
            {
                await Shell.Current.GoToAsync("//HomePage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Problema no cadastro. Tente Novamente!", "OK");
            }
        }

        [RelayCommand]
        private async Task Info()
        {
            await Shell.Current.GoToAsync("InfoPage");
        }
    }
}
