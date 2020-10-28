using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService;
using System.Threading.Tasks;

namespace DDD.Domain.Services
{
    class RevenueService : IRevenueService
    {
        private readonly IRevenueRepository _revenueRepository;

        public RevenueService(IRevenueRepository revenueRepository)
        {
            _revenueRepository = revenueRepository;
        }

        public async Task<Company> GetCompanyRevenue(string cnpj)
            => await _revenueRepository.GetCompanyInRevenue(cnpj);
    }
}
