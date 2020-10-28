using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService
{
    public interface IItemService
    {
        void PostItem(Item item);
        IList<Item> GetAllItem();
        Item GetItemById(int id);
        void DeleteItemById(int id);
        void PutItem(Item item);
        void PatchStorage(List<Item> item);
    }
}
