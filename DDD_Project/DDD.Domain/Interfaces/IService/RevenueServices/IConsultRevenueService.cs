using DDD.Domain.Entities.CompanyEntity;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.IService.RevenueServices
{
    public interface IConsultRevenueService
    {
        Task<Company> ConsultRevenueCompanyService(string cnpj);
    }
}
