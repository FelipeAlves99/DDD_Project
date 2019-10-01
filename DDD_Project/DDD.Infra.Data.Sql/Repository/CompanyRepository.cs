using DDD.Domain.Entities.CompanyEntity;
using DDD.Domain.Interfaces.IRepository;
using DDD.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Infra.Data.Sql.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private DDDProjectContext _context = new DDDProjectContext();

        public CompanyRepository(DDDProjectContext context)
        {
            _context = context;
        }

        public void DeleteCompany(int id)
        {
            _context.Set<Company>().Remove(GetCompanyById(id));
            _context.SaveChanges();
        }

        public IList<Company> GetAllCompany()
        {
            return _context.Companies
                .AsNoTracking()
                .Include(c => c.Atividade_Principal)
                .Include(c => c.Atividades_Secundarias)
                .ToList();
        }

        public Company GetCompanyByCnpj(string cnpj)
        {
            return _context.Companies
                .AsNoTracking()
                .Where(c => c.Cnpj == cnpj)
                .Include(c => c.Atividade_Principal)
                .Include(c => c.Atividades_Secundarias)
                .FirstOrDefault();
        }

        public Company GetCompanyById(int id)
        {
            return _context.Companies
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Include(c => c.Atividade_Principal)
                .Include(c => c.Atividades_Secundarias)
                .FirstOrDefault();
        }

        public Company GetCompanyByName(string name)
        {
            return _context.Companies
                .AsNoTracking()
                .Where(c => c.Nome == name)
                .Include(c => c.Atividade_Principal)
                .Include(c => c.Atividades_Secundarias)
                .FirstOrDefault();
        }

        public void PostCompany(Company company)
        {
            _context.Set<Company>().Add(company);
            _context.SaveChanges();
        }

        public void PutCompany(Company company)
        {
            _context.Attach(company);
            _context.Entry(company).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
