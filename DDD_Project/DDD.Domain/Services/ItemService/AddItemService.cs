using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.ItemServices;

namespace DDD.Domain.Services.ItemService
{
    public class AddItemService : IAddItemService
    {
        private IItemRepository _itemRepository;

        public AddItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        void IAddItemService.AddItemService(Item item)
        {
            _itemRepository.PostItem(item);
        }
    }
}
