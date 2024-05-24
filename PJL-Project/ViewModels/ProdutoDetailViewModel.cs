using CommunityToolkit.Mvvm.ComponentModel;
using PJL_Project.Models;

namespace PJL_Project.ViewModels
{
    // [QueryProperty(nameof(Id),"produtoId")]
    public partial class ProdutoDetailViewModel : ObservableObject
    {
        // private readonly ProdutosRepositorios _produtosRepositorios;
        // public ProdutoDetailViewModel()
        // {
        //     _produtosRepositorios = new ProdutosRepositorios();
        // }

        public int Id { get; set; }

        [ObservableProperty]
        private Produto _produto;

        // public async Task OnAppearing()
        // {
        //     Produto = await _produtosRepositorios.GetProduto(Id);
        // }
    }
}
