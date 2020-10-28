using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Infra.Data.Sql.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private DDDProjectContext _context = new DDDProjectContext();
        public IList<Order> GetAllOrder()
        {
            return _context.Orders
                .AsNoTracking()
                .Include(o => o.ItemOrder)
                .Include(o => o.Company)
                .ToList();
        }

        public IList<Order> GetAllOrderByCompany(int idCompany)
        {
            return _context.Orders
                .AsNoTracking()
                .Where(o => o.CompanyId == idCompany)
                .Include(o => o.ItemOrder)
                .Include(o => o.Company)
                .OrderBy(o => o.OrderDate)
                .ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders
                .AsNoTracking()
                .Where(o => o.Id == id)
                .Include(o => o.ItemOrder)
                .ThenInclude(i => i.Item)
                .Include(o => o.Company)
                .FirstOrDefault();
        }

        public void PatchOrder(Order order)
        {
            _context.Orders.Attach(order);
            _context.Entry(order).Property(o => o.Status).IsModified = true;
            _context.SaveChanges();
        }

        public int PostOrder(Order order)
        {
            foreach (var itemOrder in order.ItemOrder)
            {
                itemOrder.Item = null;
            }
            order.Company = null;

            _context.Orders.Add(order);
            _context.SaveChanges();
            return order.Id;
        }
    }
}
