using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts();

        Task<Post> GetPost(int id);
        Task<PostDTO> Create(PostDTO postDTO);

        Task Delete(int id);
        

        Task Update(Post post);

    }
}