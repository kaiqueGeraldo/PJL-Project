using CommunityToolkit.Mvvm.ComponentModel;
using PJL_Project.Models;
using System.Collections.ObjectModel;

namespace PJL_Project.ViewModels
{
    public partial class CategoryViewModel : ObservableObject
    {
        public CategoryViewModel()
        {
            Categorias = new ObservableCollection<Categoria>
            {
                new Categoria
                {
                    Descricao = "Men's bracelet",
                    Imagem = "exemplo_pulseira_homem.png"
                },
                new Categoria
                {
                    Descricao = "Men's ring",
                    Imagem = "exemplo_anel_homem.png"
                },
                new Categoria
                {
                    Descricao = "Men's anklet",
                    Imagem = "exemplo_tornozeleira_homem.png"
                },
                new Categoria
                {
                    Descricao = "wedding rings",
                    Imagem = "exemplo_alianca.png"
                },
                new Categoria
                {
                    Descricao = "Women's anklet",
                    Imagem = "exemplo_tonozeleira_mulher.png"
                },
                new Categoria
                {
                    Descricao = "Woman’s rings",
                    Imagem = "exemplo_anel_mulher.png"
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
                    Descricao = "pendants",
                    Imagem = "berloques.svg"
                },
                new Categoria
                {
                    Descricao = "Men’s necklace",
                    Imagem = "exemplo_colar_homem.png"
                }
            };
        }

        public ObservableCollection<Categoria> Categorias { get; set; }
    }
}
