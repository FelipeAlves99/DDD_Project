using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces.IService.CompanyServices
{
    public interface IDeleteCompanyService
    {
        void DeleteCompanyService(string cnpj);
    }
}
