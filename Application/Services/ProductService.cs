using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Specifications;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly  IHostingEnvironment _env;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository,
        IRepository<Category> categoryRepo,
        IHostingEnvironment env,
        UserManager<ApplicationUser> userManager,
        IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepo = categoryRepo;
            _mapper = mapper;
            _env = env;
            _userManager = userManager;
        }


        public async Task<ProductDTO> AddProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);

            var category = await _categoryRepo.GetByIdAsync(product.CategoryId);
            if (category == null)
                throw new Exception();

            if (productDTO.GetActualImage() != null)
            {
                var fileName = Path.GetFileName(productDTO.GetActualImage().FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(productDTO.GetActualImage().FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\product", newName);
                product.ImageURL = "/images/product/" + newName;

                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await productDTO.GetActualImage().CopyToAsync(fileSteam);
                }
            }

            var productInDb = await _productRepository.AddAsync(product);
            var productDTOFromDb = _mapper.Map<ProductDTO>(productInDb);

            return productDTOFromDb;
        }

        public async Task DeleteProduct(int id,int userId)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if(product != null && product.UserId == userId)
            {
                var OldfilePath = Path.Combine(_env.WebRootPath, product.ImageURL.Replace("/", "\\").Remove(0, 1));
                File.Delete(OldfilePath);
                await _productRepository.DeleteAsync(product);
            }
        }

        public async Task<List<ProductDTO>> GetAllproducts()
        {
            var spec = new ProductsWithDetailAndPaintType();
            var paintTypes = await _productRepository.GetAllBySpecification(spec);
            var paintTypeDTO = paintTypes.Select(x => _mapper.Map<ProductDTO>(x)).OrderByDescending(p => p.CreateDate).ToList();
            
            return paintTypeDTO;
        }

        public async Task<List<ProductDTO>> GetPendingPosts()
        {
            var spec = new GetPendingProductsSpecification();
            var products = await _productRepository.GetAllBySpecification(spec);
            var paintTypeDTO = products.Select(x => _mapper.Map<ProductDTO>(x)).ToList();

            return paintTypeDTO;
        }

        public async Task<List<ProductDTO>> GetProtudtsByCategory(string category)
        {
            var spec = new GetProductsByCategorySpec(category);
            var products = await _productRepository.GetAllBySpecification(spec);
            var productDTO = products.Select(x => _mapper.Map<ProductDTO>(x)).ToList();

            return productDTO;
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
            var spec = new ProductWithDetailAndPaintType(id);
            var product = await _productRepository.GetBySpecification(spec);

            product.Name = productDTO.Name;
            product.InStock = productDTO.InStock;
            product.Description = productDTO.Description;
            product.Price = productDTO.Price;

            if (productDTO.GetActualImage() != null)
            {
                if (product.ImageURL != null)
                {
                    var OldfilePath = Path.Combine(_env.WebRootPath, product.ImageURL.Replace("/", "\\").Remove(0, 1));
                    File.Delete(OldfilePath);
                }

                var fileName = Path.GetFileName(productDTO.GetActualImage().FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(productDTO.GetActualImage().FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\product", newName);
                product.ImageURL = "/images/product/" + newName;


                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await productDTO.GetActualImage().CopyToAsync(fileSteam);
                }
            }

            var category = await _categoryRepo.GetByIdAsync(productDTO.CategoryId);
            if (category == null)
                throw new Exception();

            
            await _productRepository.UpdateAsync(product);
        }


        public async Task Approve(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if(product != null && product.Status == false)
            {
                product.Status = true;
                await _productRepository.UpdateAsync(product);
            }
        }
    }
}
