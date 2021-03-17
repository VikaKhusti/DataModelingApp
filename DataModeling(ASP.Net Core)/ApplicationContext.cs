using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModeling_ASP.Net_Core_.Models;
using Microsoft.EntityFrameworkCore;

namespace DataModeling_ASP.Net_Core_
{
    public class ApplicationContext : DbContext
    {
       // public DbSet<Data> Datas { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Server=DESKTOP-SI9RL4S;Database=Datas;Trusted_Connection=True;");
        }
    }
}
