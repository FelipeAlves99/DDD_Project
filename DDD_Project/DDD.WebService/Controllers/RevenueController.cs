using System;
using System.Threading.Tasks;
using DDD.Domain.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DDD.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenueController : ControllerBase
    {

        private IRevenueRepository _companyRevenue { get; set; }

        public RevenueController(IRevenueRepository Revenue)
        {
            _companyRevenue = Revenue;
        }

        // GET: api/v1/Revenue?cnpj={cnpj}
        [HttpGet]
        public async Task<IActionResult> GetcompanyRevenue(string cnpj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var company = await _companyRevenue.GetCompanyInRevenue(cnpj);

                if (company == null)
                    return NotFound();

                return Ok(company);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}