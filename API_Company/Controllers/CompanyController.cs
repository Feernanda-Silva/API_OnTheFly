using System.Collections.Generic;
using API_Company.Models;
using API_Company.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Company.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _companyService;

        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet]
        public ActionResult<List<Company>> Get() => _companyService.Get();


        [HttpGet("{cnpj:length(19)}", Name = "GetCompany")]
        public ActionResult<Company> Get(string cnpj)
        {
            var company = _companyService.Get(cnpj);
            if (company == null)
            {
                return NotFound();
            } 

            return Ok(company); 
        }

        [HttpPost]
        public ActionResult<Company> Create(Company company)
        {
            _companyService.Create(company);
            return CreatedAtRoute("GetCompany", new { cnpj = company.Cnpj.ToString() }, company);
        }


        //[HttpPut]


        //[HttpDelete]

    }
}

