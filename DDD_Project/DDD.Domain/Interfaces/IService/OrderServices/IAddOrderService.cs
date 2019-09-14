using DDD.Domain.Entities;

namespace DDD.Domain.Interfaces.IService.OrderServices
{
    public interface IAddOrderService
    {
        /// <summary>
        /// This method add an order and returns the order's ID
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        int AddOrderService(Order order);
    }
}
