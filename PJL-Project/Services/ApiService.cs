using PJL_Project.Models;
using System.Net.Http.Json;

namespace PJL_Project.Services
{
    internal class ApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseUrlAddress.UrlRotaApi)
            };
        }

        #region Usuario Requests
        public async Task<List<Usuario>> GetUsuarios()
        {
            try
            {
                var listaUsuarios = await _httpClient.GetFromJsonAsync<List<Usuario>>("usuarios");

                return listaUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            try
            {
                var usuario = await _httpClient.GetFromJsonAsync<Usuario>($"usuarios/{id}");

                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PostUsuario(Usuario usuario)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<Usuario>("usuarios", usuario);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Usuario> AutenticarUsuario(string email, string senha)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("usuarios/autenticar", new { Email = email, Senha = senha });
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Usuario>();
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Produto Requests

        public async Task<List<Produto>> GetProdutos()
        {
            try
            {
                var listaProdutos = await _httpClient.GetFromJsonAsync<List<Produto>>("produtos");

                return listaProdutos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            try
            {
                var produto = await _httpClient.GetFromJsonAsync<Produto>($"produtos/{id}");

                return produto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PostProduto(Produto produto)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<Produto>("produtos", produto);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Item Requests

        public async Task<List<Item>> GetItems()
        {
            try
            {
                var listaItems = await _httpClient.GetFromJsonAsync<List<Item>>("items");

                return listaItems;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Item> GetItemById(int id)
        {
            try
            {
                var item = await _httpClient.GetFromJsonAsync<Item>($"items/{id}");

                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PostItem(Item item)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<Item>("items", item);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Categoria Requests

        public async Task<List<Categoria>> GetCategoria()
        {
            try
            {
                var listaCategorias = await _httpClient.GetFromJsonAsync<List<Categoria>>("categorias");

                return listaCategorias;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Categoria> GetCategoriaById(int id)
        {
            try
            {
                var categorias = await _httpClient.GetFromJsonAsync<Categoria>($"categorias/{id}");

                return categorias;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PostCategoria(Categoria categoria)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<Categoria>("categorias", categoria);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Carrinho Requests

        public async Task<List<Carrinho>> GetCarrinhos()
        {
            try
            {
                var listaCarrinhos = await _httpClient.GetFromJsonAsync<List<Carrinho>>("carrinhos");

                return listaCarrinhos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Carrinho> GetCarrinhoById(int id)
        {
            try
            {
                var carrinho = await _httpClient.GetFromJsonAsync<Carrinho>($"carrinhos/{id}");

                return carrinho;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PostCarrinho(Carrinho carrinho)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<Carrinho>("carrinhos", carrinho);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
