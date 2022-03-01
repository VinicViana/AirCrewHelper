using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class Context : DbContext
    {
        public DbSet<Pilot> Pilotos { get; set; }
        public DbSet<AirCrew> AirCrew { get; set; }
        public DbSet<CheckList> CheckList { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<AirPlane> AirPlane  { get; set; }
        public DbSet<CheckListActions> CheckListActions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\sql2019;Initial Catalog=AirCrewHelper;Integrated Security=True");
        }
    }
}