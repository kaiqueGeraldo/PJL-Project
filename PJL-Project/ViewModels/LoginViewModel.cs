using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PJL_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJL_Project.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        public LoginViewModel()
        {
        }

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _senha;

        [RelayCommand]
        private async Task Entrar()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
