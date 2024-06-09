using CommunityToolkit.Mvvm.ComponentModel;
using PJL_Project.Models;
using PJL_Project.Services;

namespace PJL_Project.ViewModels
{
    [QueryProperty(nameof(Id), "produtoId")]
    public partial class ProdutoDetailViewModel : ObservableObject
    {
        private readonly ApiService _apiService;
        public ProdutoDetailViewModel()
        {
            _apiService = new ApiService();
        }

        public int Id { get; set; }

        [ObservableProperty]
        private Produto _produto;

        public async Task OnAppearing()
        {
            Produto = await _apiService.GetProdutoById(Id);
        }
    }
}
