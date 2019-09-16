using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.CompanyServices;
using System.Collections.Generic;

namespace DDD.Domain.Services.CompanyService
{
    public class ConsultCompanyService : IConsultCompanyService
    {
        private ICompanyRepository _companyRepository;

        public ConsultCompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Company ConsultCompanyCnpjService(string cnpj)
        {
            return _companyRepository.GetCompanyByCnpj(cnpj);
            
        }

        public Company ConsultCompanyIdService(int id)
        {
            return _companyRepository.GetCompanyById(id);
        }

        public Company ConsultCompanyNameSerivce(string companyName)
        {
            return _companyRepository.GetCompanyByName(companyName);
        }

        IList<Company> IConsultCompanyService.ConsultCompanyService()
        {
            return _companyRepository.GetAllCompany();
        }
    }
}
