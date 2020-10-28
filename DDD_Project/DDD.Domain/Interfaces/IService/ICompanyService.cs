using DDD.Domain.Entities.CompanyEntity;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService
{
    public interface ICompanyService
    {
        void AddCompany(Company company);
        IList<Company> GetAllCompany();
        Company GetCompanyById(int id);
        Company GetCompanyByCnpj(string cnpj);
        Company GetCompanyByName(string companyName);
        void DeleteCompany(int id);
        void PutCompany(Company company);
    }
}
