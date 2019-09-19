using System.Collections.Generic;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.ItemServices;

namespace DDD.Domain.Services.ItemService
{
    public class UpdateItemService : IUpdateItemService
    {
        private IItemRepository _itemRepository;

        public UpdateItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void UpdateStorageService(List<Item> item)
        {
            _itemRepository.Patchitem(item);
        }

        void IUpdateItemService.UpdateItemService(Item item)
        {
            _itemRepository.PutItem(item);
        }
    }
}
