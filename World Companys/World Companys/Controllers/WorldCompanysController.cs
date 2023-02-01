using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using World_Companys.Business_Logic;
using World_Companys.Request;
using World_Companys.Response;

namespace World_Companys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldCompanysController : ControllerBase
    {
        private readonly WorldCompanysBL mWorldCompanysBL;
        public WorldCompanysController(WorldCompanysBL worldCompanysBL)
        {
            mWorldCompanysBL = worldCompanysBL;
        }
        [HttpPost("createlanguage")]
        public string CreateLanguage([FromBody]LanguageRequest languageRequest)
        {
            return mWorldCompanysBL.CreateLanguage(languageRequest);
        }
        [HttpPost("createcountry")]
        public string CreateCountry([FromBody]CountryRequest countryRequest)
        {
            return mWorldCompanysBL.CreateCountry(countryRequest);
        }
        [HttpPost("createcompany")]
        public string CreateCompany([FromBody]CompanyRequest companyRequest)
        {
            return mWorldCompanysBL.CreateCompany(companyRequest);
        }
        [HttpPost("createusers")]
        public string CreateUsers([FromBody]UsersRequest usersRequest)
        {
            return mWorldCompanysBL.CreateUsers(usersRequest);
        }
        [HttpPost("createprofile")]
        public string CreateProfile([FromBody] UserprofileRequest userprofileRequest)
        {
            return mWorldCompanysBL.CreateProfile(userprofileRequest);
        }
        [HttpPost("createusercompany")]
        public string CreateUsercompany([FromBody] UsercompanyRequest usercompanyRequest)
        {
            return mWorldCompanysBL.CreateUsercompany(usercompanyRequest);
        }
        [HttpGet("fulljoin")]
        public List<FulljoinResponse> Getall()
        {
            return mWorldCompanysBL.Getall();
        }
        [HttpGet("getbyemail")]
        public FulljoinResponse GetByEmail(string EmailId)
        {
            return mWorldCompanysBL.GetByEmail(EmailId);
        }
        [HttpPut("getupdate")]
        public string GetByUpdate()
        {
            return mWorldCompanysBL.GetByUpdate();
        }
    }
}
