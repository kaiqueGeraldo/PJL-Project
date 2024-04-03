using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class PerfilPage : ContentPage
{
	private PerfilViewModel _viewModel;
	public PerfilPage()
	{
		InitializeComponent();
		_viewModel = new PerfilViewModel();
		BindingContext = _viewModel;
	}
}