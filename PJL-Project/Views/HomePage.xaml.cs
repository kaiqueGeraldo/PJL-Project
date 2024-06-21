using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class HomePage : ContentPage
{
	private readonly HomeViewModel _viewModel;
	public HomePage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new HomeViewModel();
	}
}