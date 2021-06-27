using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<ProductDTO> AddProduct(ProductDTO productDTO);
        Task<ProductDTO> GetProduct(int id);
        Task<List<ProductDTO>> GetAllproducts();
        Task UpdateProduct(int id, ProductDTO productDTO);
        Task DeleteProduct(int id,int userId);
        Task<List<ProductDTO>> GetPendingPosts();
        Task Approve(int id);
        Task<List<ProductDTO>> GetProtudtsByCategory(string category);
    }
}