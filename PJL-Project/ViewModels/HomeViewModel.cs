using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PJL_Project.Models;
using System.Collections.ObjectModel;

namespace PJL_Project.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        public HomeViewModel()
        {
            Carrousels = new ObservableCollection<Carrousel>
            {
                new  Carrousel
                {
                    Imagem = "mulher_do_olho"
                },
                new  Carrousel
                {
                    Imagem = "mulher_do_olho"
                },
                new  Carrousel
                {
                    Imagem = "mulher_do_olho"
                },
                new  Carrousel
                {
                    Imagem = "mulher_do_olho"
                }
            };

            Produtos = new ObservableCollection<Produto>
            {
                new Produto
                {
                    Imagem = "colar_cruz_homem.svg"
                },
                new Produto
                {
                    Imagem = "casaco_colar.svg"
                },
                new Produto
                {
                    Imagem = "cinza_barbudo.svg"
                },
                new Produto
                {
                    Imagem = "corrente_fina.png"
                },
                new Produto
                {
                    Imagem = "corrente_de_bicicleta.svg"
                }
            };

            Categorias = new ObservableCollection<Categoria>
            {
                new Categoria
                {
                    Descricao = "Men’s necklace",
                    Imagem = "exemplo_colar_homem.png"
                },
                new Categoria
                {
                    Descricao = "Men's bracelet",
                    Imagem = "exemplo_pulseira_homem.png"
                },
                new Categoria
                {
                    Descricao = "Women's necklace",
                    Imagem = "exemplo_colar_mulher.png"
                },
                new Categoria
                {
                    Descricao = "Women's bracelet",
                    Imagem = "exemplo_pulseira_mulher.png"
                },
                new Categoria
                {
                    Descricao = "Women's anklet",
                    Imagem = "exemplo_tonozeleira_mulher.png"
                }
            };
        }

        public ObservableCollection<Carrousel> Carrousels { get; set; }
        public ObservableCollection<Produto> Produtos { get; set; }
        public ObservableCollection<Categoria> Categorias { get; set; }

        [RelayCommand]
        public async Task SeeAllPage()
        {
            await Shell.Current.GoToAsync("SeeAllPage");
        }

        [RelayCommand]
        private async Task ProdutoClicado(Produto produto)
        {
            await Shell.Current.GoToAsync($"ProdutoDetailPage?produtoId={produto.Id}");
        }
    }
}
