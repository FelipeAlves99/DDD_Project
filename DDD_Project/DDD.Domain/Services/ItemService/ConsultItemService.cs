using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.ItemServices;
using System.Collections.Generic;

namespace DDD.Domain.Services.ItemService
{
    public class ConsultItemService : IConsultItemService
    {
        private IItemRepository _itemRepository;

        public ConsultItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Item ConsultItemIdService(int id)
        {
            return _itemRepository.GetItembyId(id);
        }

        IList<Item> IConsultItemService.ConsultItemService()
        {
            return _itemRepository.GetAllItem();
        }
    }
}
