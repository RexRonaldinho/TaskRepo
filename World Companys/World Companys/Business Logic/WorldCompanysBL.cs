using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using World_Companys.Business_Repositary;
using World_Companys.Request;
using World_Companys.Response;

namespace World_Companys.Business_Logic
{
    public class WorldCompanysBL
    {
        private readonly WorldCompanysBR mWorldCompanysBR;
        public WorldCompanysBL(WorldCompanysBR worldCompanysBR)
        {
            mWorldCompanysBR = worldCompanysBR;
        }
        public string CreateLanguage(LanguageRequest languageRequest)
        {
            return mWorldCompanysBR.CreateLanguage(languageRequest);
        }
        public string CreateCountry(CountryRequest countryRequest)
        {
            return mWorldCompanysBR.CreateCountry(countryRequest);
        }
        public string CreateCompany(CompanyRequest companyRequest)
        {
            return mWorldCompanysBR.CreateCompany(companyRequest);
        }
        public string CreateUsers(UsersRequest usersRequest)
        {
            return mWorldCompanysBR.CreateUsers(usersRequest);
        }
        public string CreateProfile(UserprofileRequest userprofileRequest)
        {
            return mWorldCompanysBR.CreateProfile(userprofileRequest);
        }
        public string CreateUsercompany(UsercompanyRequest usercompanyRequest)
        {
            return mWorldCompanysBR.CreateUsercompany(usercompanyRequest);
        }
        public List<FulljoinResponse>Getall()
        {
            return mWorldCompanysBR.Getall();
        }
        public FulljoinResponse GetByEmail(string EmailId)
        {
            return mWorldCompanysBR.GetByEmail(EmailId);
        }
    }
}
