using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService.OrderServices
{
    public interface IConsultOrderService
    {
        IList<Order> ConsultOrderService();
        Order ConsultOrderByCompany(int companyName);
        Order ConsultOrderById(int orderId);

    }
}
