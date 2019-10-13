using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.OrderServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Services.OrderService
{
    public class ConsultOrderService : IConsultOrderService
    {
        private IOrderRepository _orderRepository;

        public ConsultOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IList<Order> ConsultOrderByCompanyService(int companyId)
        {
            return _orderRepository.GetAllOrdersCompany(companyId);
        }

        public Order ConsultOrderByIdService(int orderId)
        {
            return _orderRepository.GetOrder(orderId);
        }

        IList<Order> IConsultOrderService.ConsultOrderService()
        {
            return _orderRepository.GetAll();
        }
    }
}
