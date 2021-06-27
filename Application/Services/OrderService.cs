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
        private readonly IRepository<Product> _productRepo;

        public OrderService(IRepository<Order> orderRepo, IRepository<Basket> basketRepo,IRepository<Product> productRepo)
        {
            _orderRepo = orderRepo;
            _basketRepo = basketRepo;
            _productRepo = productRepo;
        }

        public async Task<Order> CreateOrder(Order order,int userId)
        {
            order.UserId = userId;
            order.OrderItems = new List<OrderItem>();
            await _orderRepo.AddAsync(order);
            return order;
        }

        public async Task CreateOrderAsync(int userId, Order order)
        {
            var spec = new GetUsersBasketWithItems(userId);
            var basket = await _basketRepo.GetBySpecification(spec);

            var orderInDb = await CreateOrder(order,userId);
           // order.OrderItems = new List<OrderItem>();
            var orderItems = basket.BasketItems.Select(basketItem =>
            {
                var orderItem = new OrderItem() { Price = basketItem.Price, ProductId = basketItem.ProductId };
                var productsList = basketItem.Product;
                return orderItem;
            }).ToList();

            
            order.OrderItems.AddRange(orderItems);


            var productsList = basket.BasketItems.Select(basketItem =>
            {
                var productsList = basketItem.Product;
                productsList.InStock = false;
                return productsList;
            }).ToList();



            await _productRepo.UpdateMany(productsList);
            await _orderRepo.UpdateAsync(order);
            await _basketRepo.DeleteAsync(basket);
        }

        public async Task<List<Order>> GetMyOrders(int userId)
        {
            var spec = new GetOrderByUserId(userId);
            var order  = await _orderRepo.GetAllBySpecification(spec);
            if(order == null)
            {
                return new List<Order>() {};
            }
            return order;
        }

        public async Task DeleteOrders(int userId)
        {
            var spec = new GetOrderByUserId(userId);
            var order  = await _orderRepo.GetAllBySpecification(spec);
            if(order != null)
            {
                await _orderRepo.DeleteRangeAsync(order);
            }
        }
    }
}
