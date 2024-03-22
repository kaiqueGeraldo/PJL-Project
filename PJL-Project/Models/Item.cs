using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJL_Project.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        public int NumeroPedido { get; set; }
        public Carrinho Carrinho { get; set; }

        public int CodigoProduto { get; set; }
        public Produto Produto { get; set; }
    }
}
