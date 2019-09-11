using DDD.Domain.Entities.CompanyEntity;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IRepository
{
    public interface ICompanyRepository
    {
        void PostCompany(Company company);
        IList<Company> GetAllCompany();
        Company GetCompanyById(int id);
        Company GetCompanyByCnpj(string cnpj);
        Company GetCompanyByName(string name);
        void PutCompany(Company company);
        void DeleteCompany(int id);
    }
}