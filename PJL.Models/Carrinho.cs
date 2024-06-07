namespace PJL_Project.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataRecebimento { get; set; }
        public double SubTotal { get; set; }
        public double ValorTotal { get; set; }
        public double Frete { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Item> Itens { get; set; }
    }
}
