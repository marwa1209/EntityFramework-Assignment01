using demo.Demo_Assignment03.inheritanceExample.Models;
using EmployeeInheritance = demo.Demo_Assignment03.inheritanceExample.Models.Employee;
using demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Demo_Assignment03.inheritanceExample.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #region LazyLoading
            optionsBuilder.UseLazyLoadingProxies(); 
            #endregion
            optionsBuilder.UseSqlServer("Server = . ; Database = Inheritance ; Trusted_Connection = true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPC [table per class]
            //modelBuilder.Entity<EmployeeInheritance>().ToTable("Employees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees"); 
            #endregion
            #region TPCC
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<EmployeeInheritance>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<EmployeeInheritance>();
            #endregion
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<EmployeeInheritance> Employees { get; set; }
        #region TPC [table per class] && TPH
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion

    }
}
