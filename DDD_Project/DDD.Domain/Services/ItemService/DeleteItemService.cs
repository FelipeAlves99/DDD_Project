using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.ItemServices;

namespace DDD.Domain.Services.ItemService
{
    public class DeleteItemService : IDeleteItemService
    {
        private IItemRepository _itemRepository;

        public DeleteItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void DeleteitemService(int id)
        {
            _itemRepository.DeleteItem(id);
        }
    }
}
