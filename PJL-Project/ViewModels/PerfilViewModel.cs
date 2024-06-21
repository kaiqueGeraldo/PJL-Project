using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PJL_Project.ViewModels
{
    public partial class PerfilViewModel : ObservableObject
    {
        public PerfilViewModel()
        {

        }

        [RelayCommand]
        private async Task NotFound()
        {
            await Shell.Current.GoToAsync("NotFoundPage");
        }

        [ObservableProperty]
        private ImageSource _image;

        [RelayCommand]
        private async Task TirarFoto()
        {
            if (!MediaPicker.IsCaptureSupported)
            {
                await Shell.Current.DisplayAlert("Erro", "Câmera indisponível", "OK");
                return;
            }

            var file = await MediaPicker.CapturePhotoAsync();

            if (file == null)
            {
                return;
            }

            var imageStream = await file.OpenReadAsync();

            Image = ImageSource.FromStream(() => imageStream);
        }

        [RelayCommand]
        private async Task EscolherFoto()
        {
            var file = await MediaPicker.PickPhotoAsync();

            if (file == null)
            {
                return;
            }

            var imageStream = await file.OpenReadAsync();

            Image = ImageSource.FromStream(() => imageStream);
        }
    }
}
