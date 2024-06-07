using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class ProdutoDetailPage : ContentPage
{
	private readonly ProdutoDetailViewModel _viewModel;
	public ProdutoDetailPage()
	{
		InitializeComponent();
		_viewModel = new ProdutoDetailViewModel();
		BindingContext = _viewModel;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await _viewModel.OnAppearing();
	}

}