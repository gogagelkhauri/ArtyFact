using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int userId, Order order);
        Task<List<Order>> GetMyOrders(int userId);
        Task DeleteOrders(int userId);
    }
}
