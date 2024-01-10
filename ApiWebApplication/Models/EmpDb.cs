using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiWebApplication.Models
{
    public class EmpDb: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Designation> Designations { get; set; }

        public EmpDb(DbContextOptions<EmpDb> o) : base(o)
        {
            
        }
    }
}
