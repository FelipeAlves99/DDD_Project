using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.RevenueServices;
using System.Threading.Tasks;

namespace DDD.Domain.Services.RevenueServices
{
    public class ConsultRevenueService : IConsultRevenueService
    {
        private IRevenueRepository _revenueRepository;

        public ConsultRevenueService(IRevenueRepository revenueRepository)
        {
            _revenueRepository = revenueRepository;
        }

        public async Task<Company> ConsultRevenueCompanyService(string cnpj)
        {
            return await _revenueRepository.GetCompanyInRevenue(cnpj);
        }
    }
}
