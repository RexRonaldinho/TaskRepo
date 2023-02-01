using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace World_Companys.Response
{
    public class FulljoinResponse
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Guid GuId { get; set; }
        public int CountryId { get; set; }
        public bool Status { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string EmailId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int UsersId { get; set; }
        public string LanguageName { get; set; }
        public string CountryName { get; set; }
        public string CompanyName { get; set; }
    }
}
