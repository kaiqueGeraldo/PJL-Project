using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await Shell.Current.GoToAsync("SingUpPage");
        }
        
        [RelayCommand]
        private async Task Login()
        {
            await Shell.Current.GoToAsync("LoginPage");
        }
    }
}
