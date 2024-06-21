using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class ProdutoDetailPage : ContentPage
{
	private readonly ProdutoDetailViewModel _viewModel;
	public ProdutoDetailPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new ProdutoDetailViewModel();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await _viewModel.OnAppearing();
	}

}