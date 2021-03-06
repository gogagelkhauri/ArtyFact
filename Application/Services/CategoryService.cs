using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Linq;
using Domain.Specifications;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;

namespace Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly  IHostingEnvironment _env;
        private readonly IMapper _mapper;
        public CategoryService(IRepository<Category> repository, IMapper mapper,IHostingEnvironment env)
        {
            _repository = repository;
            _mapper = mapper;
            _env = env;
        }
        public async Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            if (categoryDTO.GetActualImage() != null)
            {
                var fileName = Path.GetFileName(categoryDTO.GetActualImage().FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(categoryDTO.GetActualImage().FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\category", newName);
                category.ImageURL = "/images/category/" + newName;

                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await categoryDTO.GetActualImage().CopyToAsync(fileSteam);
                }
            }

            var categoryInDb = await _repository.AddAsync(category);
            var categoryDTOFromDb = _mapper.Map<CategoryDTO>(categoryInDb);

            return categoryDTOFromDb;
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category != null)
            {
                var OldfilePath = Path.Combine(_env.WebRootPath, category.ImageURL.Replace("/", "\\").Remove(0, 1));
                File.Delete(OldfilePath);
                await _repository.DeleteAsync(category);
            }
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            var categories = await _repository.ListAsync();
            var categoryDTO = categories.Select(x => new CategoryDTO() {Id = x.Id, Name = x.Name,ImageURL = x.ImageURL}).ToList();
            
            return categoryDTO;
        }

        public async Task<CategoryDTO> GetCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            var categoryDTO = _mapper.Map<CategoryDTO>(category);
            return categoryDTO;
        }

        public async Task UpdateCategory(int id,CategoryDTO categoryDTO)
        {
            var category = await _repository.GetByIdAsync(id);
            //var category = _mapper.Map<Category>(categoryDTO);
            if(category != null)
            {
                category.Name = categoryDTO.Name;
                if (categoryDTO.GetActualImage() != null)
                {
                    if (categoryDTO.ImageURL != null)
                    {
                        var OldfilePath = Path.Combine(_env.WebRootPath, categoryDTO.ImageURL.Replace("/", "\\").Remove(0, 1));
                        File.Delete(OldfilePath);
                    }

                    var fileName = Path.GetFileName(categoryDTO.GetActualImage().FileName);
                    var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(categoryDTO.GetActualImage().FileName);
                    var filePath = Path.Combine(_env.WebRootPath, "images\\category", newName);
                    category.ImageURL = "/images/category/" + newName;


                    using (var fileSteam = new FileStream(filePath, FileMode.Create))
                    {
                        await categoryDTO.GetActualImage().CopyToAsync(fileSteam);
                    }
                }


                await _repository.UpdateAsync(category);
            }
        }

        public async Task<CategoryDTO> GetCategoryByName(string name)
        {
            var spec = new GetCategoryByName(name);
            var category = await _repository.GetBySpecification(spec);
            var categoryDTO = _mapper.Map<CategoryDTO>(category);
            return categoryDTO;
        }

        public async Task<List<Category>> GetMostSoldCategories()
        {
            var spec = new GetCategoriesWithProducts();
            var categories = await _repository.GetAllBySpecification(spec);
            var filteredCategory= categories.OrderBy(x => x.Products.Count).ToList();

            return filteredCategory;

        }
    }
}