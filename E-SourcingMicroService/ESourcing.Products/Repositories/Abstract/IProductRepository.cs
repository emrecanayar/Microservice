using ESourcing.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Repositories.Abstract
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProdutcs();
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProdutcsByName(string name);

        Task<IEnumerable<Product>> GetProdutcsCategory(string categoryName);

        Task Create(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(string id);
    }
}
