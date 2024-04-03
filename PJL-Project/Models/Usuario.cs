using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJL_Project.Models
{
    public partial class Usuario : ObservableObject
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string ImageUrl { get; set; }

        public Usuario()
        {
        }

        [ObservableProperty]
        private string _nome;
        
        [ObservableProperty]
        private string _senha;
        
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _cpf;

        [ObservableProperty]
        private string _cep;
        
        [ObservableProperty]
        private string _imageUrl;
    }
}
