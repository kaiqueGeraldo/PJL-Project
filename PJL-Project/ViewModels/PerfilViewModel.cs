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
    public partial class PerfilViewModel : ObservableObject
    {
        public PerfilViewModel()
        {
            
        }

        [RelayCommand]
        private async Task Settings()
        {
            await Shell.Current.GoToAsync("ConfigPage");
        }

    }
}
