using PJL_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace PJL.API.Data
{
    public class DbPJLContext : DbContext
    {
        public DbPJLContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
