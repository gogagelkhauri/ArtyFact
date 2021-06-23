using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts();

        Task<PostDTO> GetPost(int id);
        Task<PostDTO> Create(PostDTO postDTO);

        Task Delete(int id);
        

        Task Update(int id, PostDTO postDTO);

        Task<PostDTO> GetPostWithUser(int id);

    }
}