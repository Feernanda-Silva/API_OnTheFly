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


        [HttpGet]


        [HttpPost]


        [HttpPut]


        [HttpDelete]

    }
}

