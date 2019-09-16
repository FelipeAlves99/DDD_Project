using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.CompanyServices;

namespace DDD.Domain.Services.CompanyService
{
    public class UpdateCompanyService : IUpdateCompanyService
    {
        private ICompanyRepository _companyRepository;

        public UpdateCompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        void IUpdateCompanyService.UpdateCompanyService(Company company)
        {
            _companyRepository.PutCompany(company);
        }
    }
}
