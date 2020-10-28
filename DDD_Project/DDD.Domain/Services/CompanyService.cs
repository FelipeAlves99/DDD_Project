using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService;
using System.Collections.Generic;

namespace DDD.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void AddCompany(Company company)
            => _companyRepository.PostCompany(company);

        public Company GetCompanyByCnpj(string cnpj)
            => _companyRepository.GetCompanyByCnpj(cnpj);

        public Company GetCompanyById(int id)
            => _companyRepository.GetCompanyById(id);

        public Company GetCompanyByName(string companyName)
            => _companyRepository.GetCompanyByName(companyName);

        public IList<Company> GetAllCompany()
            => _companyRepository.GetAllCompany();

        public void DeleteCompany(int id)
            => _companyRepository.DeleteCompany(id);

        public void PutCompany(Company company)
            => _companyRepository.PutCompany(company);
    }
}
