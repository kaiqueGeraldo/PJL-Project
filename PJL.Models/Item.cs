namespace PJL_Project.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public string? Imagem { get; set; }

        public int CarrinhoId { get; set; }
        public Carrinho Carrinho { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
