using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace World_Companys.Model
{
    public class Users
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Guid GuId { get; set; }
        public int CountryId { get; set; }
        public bool Status { get; set; }
    }
}
