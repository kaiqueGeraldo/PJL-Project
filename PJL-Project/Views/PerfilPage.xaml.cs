using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class PerfilPage : ContentPage
{
	private readonly PerfilViewModel _viewModel;
	public PerfilPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new PerfilViewModel();
	}
}