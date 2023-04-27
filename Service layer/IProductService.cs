using POS.Model;
using POS_SuperStore.Data;
using Telerik.SvgIcons;

namespace POS_SuperStore.Service_layer
{
        public interface IProductService
        {
            Task<List<Product>> GetAllProductsAsync();
            Task<Product> GetProductByIdAsync(int id);
            Task<List<Product>> UpdateProductAsync(Product product);
            Task<List<Product>> DeleteProductAsync(int id);
            Task<List<Product>> CreateProduct(Product product);
            Task<List<Product>> BuyProductAsync(Product product,int quantity);
    }

}
