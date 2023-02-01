using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace World_Companys.Response
{
    public class UserprofileResponse
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string EmailId { get; set; }
        public int UserId { get; set; }
    }
}
