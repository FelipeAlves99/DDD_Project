using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces.IRepository
{
    public interface IOrderRepository
    {
        int PostOrder(Order order);

        /// <summary>
        /// Is used to call the ItemRepository Patch method to update it's stock.
        /// </summary>
        /// <param name="order"></param>
        void PatchOrder(Order order);

        IList<Order> GetAllOrder();
        Order GetOrderById(int id);
        IList<Order> GetAllOrderByCompany(int idCompany);
    }
}
