﻿using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Specifications;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IRepository<PaintType> _paintTypeRepository;
        private readonly  IHostingEnvironment _env;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository,
        IRepository<PaintType> paintTypeRepository,
        IRepository<Category> categoryRepo,
        IHostingEnvironment env,
        IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepo = categoryRepo;
            _mapper = mapper;
            _paintTypeRepository = paintTypeRepository;
            _env = env;
        }


        public async Task<ProductDTO> AddProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);

            var category = _categoryRepo.GetByIdAsync(product.Category.Id).Result;
            product.Category = category;

            if (productDTO.ActualImage != null)
            {
                // if(userProfileInDb.Image != null)
                // {
                //     var OldfilePath = Path.Combine(_env.WebRootPath,  userProfileInDb.Image.Replace("/", "\\").Remove(0, 1));
                //     File.Delete(OldfilePath);
                // }

                var fileName = Path.GetFileName(productDTO.ActualImage.FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(productDTO.ActualImage.FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\product", newName);
                product.ImageURL = "/images/product/" + newName;


                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await productDTO.ActualImage.CopyToAsync(fileSteam);
                }
            }

            if(product.ProductDetail.PaintType.Id != 0)
            {
                var paintType = await _paintTypeRepository.GetByIdAsync(product.ProductDetail.PaintType.Id);
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
            //var product = _mapper.Map<Product>(productDTO);
            var spec = new ProductWithDetailAndPaintType(id);
            var product = await _productRepository.GetBySpecification(spec);

            product.Name = productDTO.Name;
            product.InStock = productDTO.InStock;
            product.Description = productDTO.Description;
            product.ImageURL = productDTO.ImageURL;
            product.Price = productDTO.Price;
            product.Price = productDTO.Price;
            if(productDTO.Category == null)
            {
                product.Category = null;
            }
            else if (_categoryRepo.GetByIdAsync(productDTO.Category.Id).Result.Id != productDTO.Category.Id)
            {
                var cat = _categoryRepo.GetByIdAsync(productDTO.Category.Id).Result;
                product.Category = cat;
            }
            await _productRepository.UpdateAsync(product);
        }
    }
}
