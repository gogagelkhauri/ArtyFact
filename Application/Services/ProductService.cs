using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }


        public Task<ProductDTO> AddProduct(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> GetAllproducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(int id, ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
