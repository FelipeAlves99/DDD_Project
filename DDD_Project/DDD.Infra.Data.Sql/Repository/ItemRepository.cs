using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Infra.Data.Sql.Repository
{
    public class ItemRepository : IItemRepository
    {
        private DDDProjectContext _context = new DDDProjectContext();

        public ItemRepository(DDDProjectContext context)
        {
            _context = context;
        }

        public void DeleteItem(int id)
        {
            var items = _context.Items
                .Where(i => i.Id == id)
                .FirstOrDefault();

            if (items != null)
            {
                _context.Remove(items);
                _context.SaveChanges();
            }
        }

        public IList<Item> GetAllItem()
        {
            return _context.Items
                .AsNoTracking()
                .Include(i => i.ItemOrder)
                .ToList();
        }

        public Item GetItemById(int id)
        {
            return _context.Items
                .AsNoTracking()
                .Where(i => i.Id == id)
                .Include(i => i.ItemOrder)
                .FirstOrDefault();
        }

        public void PatchItem(IList<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Item item = new Item();
                item = items.ElementAt(i);

                _context.Attach(item);
                _context.Entry(item).Property(p => p.StorageQuantity).IsModified = true;
                _context.SaveChanges();
            }
        }

        public void PostItem(Item item)
        {
            _context.Set<Item>().Add(item);
            _context.SaveChanges();
        }

        public void PutItem(Item item)
        {
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
