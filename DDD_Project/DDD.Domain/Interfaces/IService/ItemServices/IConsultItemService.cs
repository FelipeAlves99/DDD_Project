using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService.ItemServices
{
    public interface IConsultItemService
    {
        IList<Item> ConsultItemService();
        Item ConsultItemIdService(int id);        
    }
}
