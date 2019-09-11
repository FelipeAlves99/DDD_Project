using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IRepository
{
    public interface IItemRepository
    {
        void PostItem(Item item);
        IList<Item> GetAllItem();
        Item GetItembyId(int id);
        void PutItem(Item item);

        /// <summary>
        /// Updates the items stock
        /// </summary>
        /// <param name="items"></param>
        void Patchitem(IList<Item> items);

        void DeleteItem(int id);
    }
}
