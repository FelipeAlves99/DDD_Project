using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService.ItemServices
{
    public interface IUpdateItemService
    {
        void UpdateItemService(Item item);
        void UpdateStorageService(List<Item> item);
    }
}
