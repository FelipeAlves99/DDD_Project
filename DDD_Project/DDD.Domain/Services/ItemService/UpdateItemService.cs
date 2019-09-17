using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.ItemServices;

namespace DDD.Domain.Services.ItemService
{
    public class UpdateItemService : IUpdateItemService
    {
        private IItemRepository _itemRepository;
        void IUpdateItemService.UpdateItemService(Item item)
        {
            _itemRepository.PutItem(item);
        }
    }
}
