using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DDD.Domain.Entities.CompanyEntity;
using DDD.Infra.Data.Sql.Data.Context;
using DDD.Domain.Interfaces.IService.CompanyServices;

namespace DDD.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private IAddCompanyService _addCompany { get; set; }
        private IConsultCompanyService _consultCompany { get; set; }
        private IDeleteCompanyService _deleteCompany { get; set; }
        private IUpdateCompanyService _updateCompany { get; set; }

        public CompaniesController(IAddCompanyService addCompany, IConsultCompanyService consultCompany,
            IDeleteCompanyService deleteCompany, IUpdateCompanyService updateCompany)
        {
            _addCompany = addCompany;
            _consultCompany = consultCompany;
            _deleteCompany = deleteCompany;
            _updateCompany = updateCompany;
        }

        // GET: api/v1/Companys?id={id}
        [HttpGet]
        public IActionResult GetCompany(int? id, string cnpj, string name)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Company company = null;
                if (!id.HasValue && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(cnpj))
                    return Ok(_consultCompany.ConsultCompanyService());

                else if (id.HasValue && id != 0)
                    company = _consultCompany.ConsultCompanyIdService(Convert.ToInt32(id));

                else if (string.IsNullOrEmpty(name))
                    company = _consultCompany.ConsultCompanyCnpjService(cnpj);

                else if (string.IsNullOrEmpty(cnpj))
                    company = _consultCompany.ConsultCompanyNameSerivce(name);

                if (company != null)
                    return Ok(company);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/v1/Companys?cnpj={cnpj}
        [HttpPut]
        public IActionResult PutCompany(string cnpj, [FromBody] Company Company)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (cnpj != Company.Cnpj)
                    return BadRequest();
                else
                {
                    _updateCompany.UpdateCompanyService(Company);
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/v1/Companys        
        [HttpPost]
        public IActionResult PostCompany([FromBody] Company Company)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _addCompany.AddCompanyService(Company);
                return CreatedAtAction("PostCompany", new { id = Company.Id }, Company);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE: api/v1/Companys?cnpj={cnpj}
        [HttpDelete]
        public IActionResult DeleteCompany(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _deleteCompany.DeleteCompanyService(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
