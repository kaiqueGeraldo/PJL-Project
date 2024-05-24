namespace PJL_Project.Models
{
    public class Carrinho
    {
        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataRecebimento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Frete { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Item> Itens { get; set; }
    }
}
