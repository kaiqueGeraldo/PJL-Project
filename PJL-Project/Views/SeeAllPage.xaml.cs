using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class SeeAllPage : ContentPage
{
	private readonly SeeAllViewModel _viewModel;
	public SeeAllPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new SeeAllViewModel();
	}
}