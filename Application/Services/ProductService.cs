using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Specifications;
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
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<PaintType> _paintTypeRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository,
        IRepository<PaintType> paintTypeRepository,
        IRepository<Category> categoryRepo,
        IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepo = categoryRepo;
            _mapper = mapper;
            _paintTypeRepository = paintTypeRepository;
        }


        public async Task<ProductDTO> AddProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);

            var category = _categoryRepo.GetByIdAsync(product.Category.Id).Result;
            product.Category = category;

            if(product.ProductDetail != null)
            {
                var paintType = _paintTypeRepository.GetByIdAsync(product.Category.Id).Result;
                product.ProductDetail.PaintType = paintType;
            }

            var productInDb = await _productRepository.AddAsync(product);
            var productDTOFromDb = _mapper.Map<ProductDTO>(productInDb);

            return productDTOFromDb;
        }

        public async Task DeleteProduct(int id)
        {
            var category = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(category);
        }

        public async Task<List<ProductDTO>> GetAllproducts()
        {
            var spec = new ProductsWithDetailAndPaintType();
            var paintTypes = await _productRepository.GetAllBySpecification(spec);
            var paintTypeDTO = paintTypes.Select(x => _mapper.Map<ProductDTO>(x)).ToList();
            
            return paintTypeDTO;
        }

        public async Task<ProductDTO> GetProduct(int id)
        {
            var spec = new ProductWithDetailAndPaintType(id);
            var product = await _productRepository.GetBySpecification(spec);
            var productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }

        public async Task UpdateProduct(int id, ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateAsync(product);
        }
    }
}
