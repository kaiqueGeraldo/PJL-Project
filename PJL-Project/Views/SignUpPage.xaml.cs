using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class SignUpPage : ContentPage
{
    private readonly SignUpViewModel _viewModel;
	public SignUpPage()
	{
		InitializeComponent();
        _viewModel = new SignUpViewModel();
        BindingContext = _viewModel;
    }

    private void ShowPassword_Clicked(object sender, EventArgs e)
    {
        SenhaEntry.IsPassword = false;
        EyeOff.IsVisible = false;
        EyeOn.IsVisible = true;
    }

    private void HidePassword_Clicked(object sender, EventArgs e)
    {
        SenhaEntry.IsPassword = true;
        EyeOff.IsVisible = true;
        EyeOn.IsVisible = false;
    }
}