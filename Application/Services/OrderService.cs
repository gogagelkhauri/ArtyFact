using Domain.Entities;
using Domain.Entities.Basket;
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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepo;
        private readonly IRepository<Basket> _basketRepo;

        public OrderService(IRepository<Order> orderRepo, IRepository<Basket> basketRepo)
        {
            _orderRepo = orderRepo;
            _basketRepo = basketRepo;
        }

        public async Task CreateOrderAsync(int userId, Order order)
        {
            var spec = new GetUsersBasketWithItems(userId);
            var basket = await _basketRepo.GetBySpecification(spec);

            order.UserId = userId;
            order.OrderItems = new List<OrderItem>();
            var orderItems = basket.BasketItems.Select(basketItem =>
            {
                var orderItem = new OrderItem() { Price = basketItem.Price, ProductId = basketItem.ProductId };
                return orderItem;
            }).ToList();
            order.OrderItems.AddRange(orderItems);

            await _orderRepo.AddAsync(order);
            await _basketRepo.DeleteAsync(basket);
        }
    }
}
