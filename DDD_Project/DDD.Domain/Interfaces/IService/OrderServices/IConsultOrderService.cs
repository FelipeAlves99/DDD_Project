﻿using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService.OrderServices
{
    public interface IConsultOrderService
    {
        IList<Order> ConsultOrderService();
        IList<Order> ConsultOrderByCompany(int companyId);
        Order ConsultOrderById(int orderId);

    }
}
