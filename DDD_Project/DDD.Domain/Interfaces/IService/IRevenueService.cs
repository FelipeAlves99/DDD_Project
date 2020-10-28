using DDD.Domain.Entities.CompanyEntity;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.IService
{
    public interface IRevenueService
    {
        Task<Company> GetCompanyRevenue(string cnpj);
    }
}
