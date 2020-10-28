using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService;
using System.Collections.Generic;

namespace DDD.Domain.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void DeleteItemById(int id)
            => _itemRepository.DeleteItem(id);

        public IList<Item> GetAllItem()
            => _itemRepository.GetAllItem();

        public Item GetItemById(int id)
            => _itemRepository.GetItemById(id);

        public void PatchStorage(List<Item> item)
            => _itemRepository.PatchItem(item);

        public void PostItem(Item item)
            => _itemRepository.PostItem(item);

        public void PutItem(Item item)
            => _itemRepository.PutItem(item);
    }
}
