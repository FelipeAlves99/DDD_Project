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

        IList<Order> GetAll();
        Order GetOrder(int id);
        IList<Order> GetAllOrdersCompany(int idCompany);
    }
}
