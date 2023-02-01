using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using World_Companys.Model;

namespace World_Companys.Database
{
    public class WorldCompanysDBContext : DbContext
    {
        public WorldCompanysDBContext(DbContextOptions<WorldCompanysDBContext> options) : base(options)
        {

        }
        public DbSet<Language> Language { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Userprofile> Userprofile { get; set; }
        public DbSet<Usercompany> Usercompany { get; set; }
    }
}
