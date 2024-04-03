using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class TypeLoginPage : ContentPage
{
	private TypeLoginViewModel _viewModel;
	public TypeLoginPage()
	{
		InitializeComponent();
		_viewModel = new TypeLoginViewModel();
		BindingContext = _viewModel;
    }
}