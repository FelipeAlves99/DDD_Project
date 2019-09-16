using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.CompanyServices;

namespace DDD.Domain.Services.CompanyService
{
    public class DeleteCompanyService : IDeleteCompanyService
    {
        private ICompanyRepository _companyRepository;

        public DeleteCompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        void IDeleteCompanyService.DeleteCompanyService(int id)
        {
            _companyRepository.DeleteCompany(id);
        }
    }
}
