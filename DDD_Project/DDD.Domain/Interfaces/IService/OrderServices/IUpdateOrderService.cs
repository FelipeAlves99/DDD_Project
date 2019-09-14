using DDD.Domain.Entities;

namespace DDD.Domain.Interfaces.IService.OrderServices
{
    public interface IUpdateOrderService
    {
        void UpdateOrderService(Order order);
    }
}
