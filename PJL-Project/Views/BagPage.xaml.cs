using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class BagPage : ContentPage
{
	private readonly BagViewModel _viewModel;
	public BagPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new BagViewModel();
	}
}