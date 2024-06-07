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
    public partial class SingUpViewModel : ObservableObject
    {
        public SingUpViewModel()
        {
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
            await Shell.Current.GoToAsync("//HomePage");
        }

        [RelayCommand]
        private async Task Info()
        {
            await Shell.Current.GoToAsync("InfoPage");
        }
    }
}
