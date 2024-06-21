using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class InfoPage : ContentPage
{
	private readonly InfoViewModel _viewModel;
	public InfoPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new InfoViewModel();
	}
}