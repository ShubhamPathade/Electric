using Microsoft.EntityFrameworkCore;
using Project.Core.Domain.Branches;
using Project.Core.Domain.Cities;
using Project.Core.Domain.EmployeeType;
using Project.Core.Domain.States;
using Project.Core.Domain.Vendor;
using Project.Data.Mapping.Cities;
using Project.Data.Mapping.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options) { }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<EmployeeTypes> EmployeeTypes { get; set; } 
        public DbSet<MainBranch> MainBranch { get; set; }
        public DbSet<SubBranche> SubBranche { get; set;}
        public DbSet<SubBranchEmployees> SubBranchEmployees { get; set; }   
        public DbSet<Vendor> Vendor { get; set; }   

    }
}
