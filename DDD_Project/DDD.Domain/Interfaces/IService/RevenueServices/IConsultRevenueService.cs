using DDD.Domain.Entities.CompanyEntity;

namespace DDD.Domain.Interfaces.IService.RevenueServices
{
    public interface IConsultRevenueService
    {
        Company ConsultRevenueCompanyService(string cnpj);
    }
}
