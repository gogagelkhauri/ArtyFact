
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

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Post> GetPost(int id)
        {
            throw new System.NotImplementedException();
        }

        public  async Task<List<Post>> GetPosts()
        {
            var posts = await _postRepo.ListAsync();
            
            return posts;
        }

        public Task Update(Post post)
        {
            throw new System.NotImplementedException();
        }
    }
}