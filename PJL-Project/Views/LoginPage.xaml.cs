using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class LoginPage : ContentPage
{
	private LoginViewModel _viewModel;
	public LoginPage()
	{
		InitializeComponent();
		_viewModel = new LoginViewModel();
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