
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Specifications;
using Microsoft.AspNetCore.Hosting;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepo;
        private readonly IMapper _mapper;
        private readonly  IHostingEnvironment _env;
        public PostService(IRepository<Post> postRepo,IMapper mapper,IHostingEnvironment env)
        {
            _postRepo = postRepo;
            _mapper = mapper;
            _env = env;
        }
         public async Task<PostDTO> Create(PostDTO postDTO)
        {
            var post = _mapper.Map<Post>(postDTO);

            if (postDTO.GetActualImage() != null)
            {
                var fileName = Path.GetFileName(postDTO.GetActualImage().FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(postDTO.GetActualImage().FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\post", newName);
                post.ImageURL = "/images/post/" + newName;

                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await postDTO.GetActualImage().CopyToAsync(fileSteam);
                }
            }

            var postInDb = await _postRepo.AddAsync(post);
            var postDTOFromDb = _mapper.Map<PostDTO>(postInDb);

            return postDTOFromDb;
        }

        public async Task Delete(int id)
        {
            var post = await _postRepo.GetByIdAsync(id);
            if (post != null)
            {
                var OldfilePath = Path.Combine(_env.WebRootPath, post.ImageURL.Replace("/", "\\").Remove(0, 1));
                File.Delete(OldfilePath);
                await _postRepo.DeleteAsync(post);
            }
        }

        public async Task<PostDTO> GetPost(int id)
        {
            var post = await _postRepo.GetByIdAsync(id);
            var postDTO = _mapper.Map<PostDTO>(post);
            return postDTO;
        }

        public async Task<PostDTO> GetPostWithUser(int id)
        {
            var spec = new GetPostWithUserSpecification(id);
            var post = await _postRepo.GetBySpecification(spec);
            var postDTO = _mapper.Map<PostDTO>(post);
            return postDTO;
        }

        public  async Task<List<Post>> GetPosts()
        {
            var posts = await _postRepo.ListAsync();
            
            return posts;
        }

        public async Task Update(int id, PostDTO postDTO)
        {
            var post = await _postRepo.GetByIdAsync(id);

            post.Title = postDTO.Title;
            post.Description = postDTO.Description;

            if (postDTO.GetActualImage() != null)
            {
                if (postDTO.ImageURL != null)
                {
                    var OldfilePath = Path.Combine(_env.WebRootPath, postDTO.ImageURL.Replace("/", "\\").Remove(0, 1));
                    File.Delete(OldfilePath);
                }

                var fileName = Path.GetFileName(postDTO.GetActualImage().FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(postDTO.GetActualImage().FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\product", newName);
                post.ImageURL = "/images/product/" + newName;


                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await postDTO.GetActualImage().CopyToAsync(fileSteam);
                }
            }



            await _postRepo.UpdateAsync(post);
        }

    }
}