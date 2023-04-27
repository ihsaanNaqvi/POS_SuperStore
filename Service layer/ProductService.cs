using Microsoft.AspNetCore.Components;
using POS.Model;
using POS_SuperStore.Pages;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Numerics;

namespace POS_SuperStore.Service_layer
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public async Task<List<Product>> CreateProduct(Product product)
        {
            ProductViewModel productViewModel = new()
            {
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = product.Quantity
            };

            var products = await _httpClient.PostJsonAsync<List<Product>>("https://localhost:44381/api/POSProduct", productViewModel);
            return products;
        }

        public async Task<List<Product>> DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"https://localhost:44381/api/POSProduct/{id}");
            var products = await _httpClient.GetJsonAsync<List<Product>>("https://localhost:44381/api/POSProduct");
            return products;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await _httpClient.GetJsonAsync<List<Product>>("https://localhost:44381/api/POSProduct");
            return products;
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> UpdateProductAsync(Product product)
        {
            var products = await _httpClient.PutJsonAsync<List<Product>>("https://localhost:44381/api/POSProduct/" + product.Id, product);
            return products;
        }

        

        public async Task<List<Product>> BuyProductAsync(Product product,int quantity)
        {
           return  await _httpClient.PutJsonAsync<List<Product>>($"https://localhost:44381/api/POSProduct/buy/{quantity}", product );
            
            
        }

        
    }
}
