using PJL_Project.ViewModels;

namespace PJL_Project.Views;

public partial class BookmarkPage : ContentPage
{
	private readonly BookmarkViewModel _viewModel;
	public BookmarkPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new BookmarkViewModel();
	}
}