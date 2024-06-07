using CommunityToolkit.Mvvm.ComponentModel;

namespace PJL_Project.Models
{
    public partial class Usuario : ObservableObject
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string ImageUrl { get; set; }

        public Usuario()
        {
        }
    }
}
