using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<ProductDTO> AddProduct(ProductDTO categoryDTO);
        Task<ProductDTO> GetProduct(int id);
        Task<List<ProductDTO>> GetAllproducts();
        Task UpdateProduct(int id, ProductDTO categoryDTO);
        Task DeleteProduct(int id);
    }
}