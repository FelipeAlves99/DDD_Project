using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.CompanyServices;

namespace DDD.Domain.Services.CompanyService
{
    public class AddCompanyService : IAddCompanyService
    {
        private ICompanyRepository _companyRepository;

        public AddCompanyService(ICompanyRepository CompanyRepository)
        {
            _companyRepository = CompanyRepository;
        }

        void IAddCompanyService.AddCompanyService(Company company)
        {
            _companyRepository.PostCompany(company);
        }
    }
}
