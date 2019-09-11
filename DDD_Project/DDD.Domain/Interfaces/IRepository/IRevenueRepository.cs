using DDD.Domain.Entities.CompanyEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.IRepository
{
    public interface IRevenueRepository
    {
        Task<Company> GetCompanyInRevenue(string cnpj); 
    }
}
