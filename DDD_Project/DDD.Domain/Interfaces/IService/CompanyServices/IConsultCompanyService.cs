using DDD.Domain.Entities.CompanyEntity;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService.CompanyServices
{
    public interface IConsultCompanyService
    {
        IList<Company> ConsultCompanyService();
        Company ConsultCompanyIdService(int id);
        Company ConsultCompanyCnpjService(string cnpj);
        Company ConsultCompanyNameSerivce(string companyName);
    }
}
