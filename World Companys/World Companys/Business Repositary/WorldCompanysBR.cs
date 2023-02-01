using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using World_Companys.Constant;
using World_Companys.Database;
using World_Companys.Model;
using World_Companys.Request;
using World_Companys.Response;

namespace World_Companys.Business_Repositary
{
    public class WorldCompanysBR
    {
        private readonly WorldCompanysDBContext mWorldCompanysDBContext;
        public WorldCompanysBR(WorldCompanysDBContext worldCompanysDBContext)
        {
            mWorldCompanysDBContext = worldCompanysDBContext;
        }
        public string CreateLanguage(LanguageRequest languageRequest)
        {
            Language language = new Language()
            {
                Id = languageRequest.Id,
                LanguageName = languageRequest.LanguageName,
            };
            mWorldCompanysDBContext.Language.Add(language);
            mWorldCompanysDBContext.SaveChanges();
            return $"Created-{language.Id}";
        }
        public string CreateCountry(CountryRequest countryRequest)
        {
            Country country = new Country()
            {
                Id = countryRequest.Id,
                CountryName = countryRequest.CountryName
            };
            mWorldCompanysDBContext.Country.Add(country);
            mWorldCompanysDBContext.SaveChanges();
            return $"Created-{country.Id}";
        }
        public string CreateCompany(CompanyRequest companyRequest)
        {
            Company company = new Company()
            {
                Id = companyRequest.Id,
                CompanyName = companyRequest.CompanyName,
                Status = companyRequest.Status
            };
            if (companyRequest.Status == true)
            {
                company.Status = StatusConstant.Active;
            }
            else
            {
                company.Status = StatusConstant.DeActive;
            }
            mWorldCompanysDBContext.Company.Add(company);
            mWorldCompanysDBContext.SaveChanges();
            return $"Created-{company.Id}";
        }
        public string CreateUsers(UsersRequest usersRequest)
        {
            Users users = new Users()
            {
                Id = usersRequest.Id,
                LanguageId = usersRequest.LanguageId,
                CountryId = usersRequest.CountryId,
                Status = usersRequest.Status,
                GuId = Guid.NewGuid(),
            };
            if (usersRequest.Status == true)
            {
                users.Status = StatusConstant.Active;
            }
            else
            {
                users.Status = StatusConstant.DeActive;
            }
            mWorldCompanysDBContext.Users.Add(users);
            mWorldCompanysDBContext.SaveChanges();
            return $"Created-{users.Id}";
        }
        public string CreateProfile(UserprofileRequest userprofileRequest)
        {
            Userprofile userprofile = new Userprofile()
            {
                Id = userprofileRequest.Id,
                Firstname = userprofileRequest.Firstname,
                Middlename = userprofileRequest.Middlename,
                Lastname = userprofileRequest.Lastname,
                EmailId = userprofileRequest.EmailId,
                UserId = userprofileRequest.UserId
            };
            mWorldCompanysDBContext.Userprofile.Add(userprofile);
            mWorldCompanysDBContext.SaveChanges();
            return $"Created-{userprofile.Id}";
        }
        public String CreateUsercompany(UsercompanyRequest usercompanyRequest)
        {
            Usercompany usercompany = new Usercompany()
            {
                Id = usercompanyRequest.Id,
                CompanyId = usercompanyRequest.CompanyId,
                UsersId = usercompanyRequest.UsersId
            };
            mWorldCompanysDBContext.Usercompany.Add(usercompany);
            mWorldCompanysDBContext.SaveChanges();
            return $"Created-{usercompany.Id}";
        }
        public List<FulljoinResponse>Getall()
        {
            List<FulljoinResponse> fulljoinResponse = (from user in mWorldCompanysDBContext.Users
                                                       join language in mWorldCompanysDBContext.Language on user.LanguageId equals language.Id
                                                       join country in mWorldCompanysDBContext.Country on user.CountryId equals country.Id
                                                       join userprofile in mWorldCompanysDBContext.Userprofile on user.Id equals userprofile.UserId
                                                       join usercompany in mWorldCompanysDBContext.Usercompany on user.Id equals usercompany.UsersId
                                                       join company in mWorldCompanysDBContext.Company on usercompany.CompanyId equals company.Id
                                                       select new FulljoinResponse
                                                       {
                                                           Id = user.Id,
                                                           LanguageId = user.LanguageId,
                                                           GuId = user.GuId,
                                                           CountryId = user.CountryId,
                                                           Status = user.Status,
                                                           LanguageName = language.LanguageName,
                                                           CountryName = country.CountryName,
                                                           Firstname = userprofile.Firstname,
                                                           Middlename = userprofile.Middlename,
                                                           Lastname = userprofile.Lastname,
                                                           EmailId = userprofile.EmailId,
                                                           UserId = userprofile.UserId,
                                                           CompanyId = usercompany.CompanyId,
                                                           UsersId = usercompany.UsersId,
                                                           CompanyName = company.CompanyName
                                                       }).ToList();
            return fulljoinResponse;
        }
        public FulljoinResponse GetByEmail(string EmailId)
        {
            FulljoinResponse fulljoinResponse = (from profile in mWorldCompanysDBContext.Userprofile
                                                 where profile.EmailId == EmailId
                                                 join user in mWorldCompanysDBContext.Users on profile.UserId equals user.Id
                                                 join language in mWorldCompanysDBContext.Language on user.LanguageId equals language.Id
                                                 join country in mWorldCompanysDBContext.Country on user.CountryId equals country.Id
                                                 join usercompany in mWorldCompanysDBContext.Usercompany on user.Id equals usercompany.UsersId
                                                 join company in mWorldCompanysDBContext.Company on usercompany.CompanyId equals company.Id
                                                 select new FulljoinResponse
                                                 {
                                                     Id = user.Id,
                                                     LanguageId = user.LanguageId,
                                                     GuId = user.GuId,
                                                     CountryId = user.CountryId,
                                                     Status = user.Status,
                                                     LanguageName = language.LanguageName,
                                                     CountryName = country.CountryName,
                                                     Firstname = profile.Firstname,
                                                     Middlename = profile.Middlename,
                                                     Lastname = profile.Lastname,
                                                     EmailId = profile.EmailId,
                                                     UserId = profile.UserId,
                                                     CompanyId = usercompany.CompanyId,
                                                     UsersId = usercompany.UsersId,
                                                     CompanyName = company.CompanyName
                                                 }).FirstOrDefault();
            return fulljoinResponse;
        }
    }
}
