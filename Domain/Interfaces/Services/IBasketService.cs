using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.Basket;

namespace Domain.Interfaces.Services
{
    public interface IBasketService
    {
        Task AddToBasket(int userId,int productId);
        Task RemoveFromBasket(int userId,int productId);
        Task<Basket> GetOrCreateBasket(int userId);
    }
}