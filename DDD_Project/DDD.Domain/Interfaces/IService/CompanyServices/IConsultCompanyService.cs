using DDD.Domain.Entities.CompanyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces.IService.CompanyServices
{
    public interface IConsultCompanyService
    {
        IList<Company> ConsultCompanyService();
        Company ConsultCompanyIdService(int id);
        Company ConsultCompanyCnpjService(string cnpj);
        Company ConsultCompanyFantasiaSerivce(string companyName);
    }
}
