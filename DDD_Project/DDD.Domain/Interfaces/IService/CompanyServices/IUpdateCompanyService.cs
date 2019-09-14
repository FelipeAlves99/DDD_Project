using DDD.Domain.Entities.CompanyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces.IService.CompanyServices
{
    public interface IUpdateCompanyService
    {
        void UpdateCompanyService(Company company);
    }
}
