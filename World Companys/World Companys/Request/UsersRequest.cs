using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace World_Companys.Request
{
    public class UsersRequest
    {
        public int Id { get; set; }
        public int LanguageId { get; set;}
        public int CountryId { get; set; }
        public bool Status { get; set; }
    }
}
