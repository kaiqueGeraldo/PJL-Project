using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PJL_Project.ViewModels
{
    public partial class InfoViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task Kaique()
        {
            string url = "https://www.instagram.com/kaiiquex_/";
            await Launcher.OpenAsync(new Uri(url));
        }
        
        [RelayCommand]
        public async Task Gabi()
        {
            string url = "https://www.instagram.com/gabi_milare/";
            await Launcher.OpenAsync(new Uri(url));
        } 
        
        [RelayCommand]
        public async Task Pontolio()
        {
            string url = "https://www.instagram.com/pontolioo/";
            await Launcher.OpenAsync(new Uri(url));
        }
    }
}
