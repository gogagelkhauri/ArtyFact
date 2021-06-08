using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Linq;
using Domain.Specifications;
using Domain.Entities.Basket;

namespace Application.Services
{
    public class BasketService : IBasketService
    {
        private readonly IRepository<Basket> _repository;
        private readonly IRepository<BasketItem> _basketItemRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;
        public BasketService(IRepository<Basket> repository,
        IRepository<BasketItem> basketItemRepository,
        IRepository<Product> productRepository,
        IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _productRepository = productRepository;
            _basketItemRepository = basketItemRepository;
        }


        public async Task<Basket> GetOrCreateBasket(int userId)
        {
            var spec = new GetUsersBasketWithItems(userId);
            var basket = await _repository.GetBySpecification(spec);
            if(basket == null)
            {
                basket = new Basket() 
                {
                    UserId = userId,
                    BasketItems = new List<BasketItem>()
                };
                await _repository.AddAsync(basket);
            }
            return basket;
        }

        public async Task AddToBasket(int userId,int productId)
        {
            var basket = await GetOrCreateBasket(userId);
            var exists = basket.BasketItems.Where(x => x.ProductId == productId).FirstOrDefault();
            if(exists == null)
            {
                var product = await _productRepository.GetByIdAsync(productId);
                basket.BasketItems.Add(new BasketItem
                {
                    Price = product.Price,
                    BasketId = basket.Id,
                    ProductId = productId
                });

                await _repository.UpdateAsync(basket);

            }
            
        }

        public async Task RemoveFromBasket(int userId,int productId)
        {
            var basket = await GetOrCreateBasket(userId);
            //var product = await _productRepository.GetByIdAsync(productId);
            var spec = new GetBasketItemByProductSpecification(productId,basket.Id);
            var item = await _basketItemRepository.GetBySpecification(spec);
            var basketItem = basket.BasketItems.Where(x => x.Id == item.Id).FirstOrDefault();
            basket.BasketItems.Remove(basketItem);
            
            await _repository.UpdateAsync(basket);
        }
    }
}