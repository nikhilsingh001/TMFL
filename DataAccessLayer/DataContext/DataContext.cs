using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using DataAccessLayer.Models;

namespace DataAccessLayer.DataContext
{
    public class DataContext : DbContext
    {



        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Emp> emps { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Branch> branches { get; set; }

        public DbSet<Zone> Zones { get; set; }

        public DbSet<Technology> Technologys { get; set; }

        public DbSet<EmployeeDocument> Document { get; set; }
        public DbSet<EmpTech> Tech { get; set; }

    }
}
