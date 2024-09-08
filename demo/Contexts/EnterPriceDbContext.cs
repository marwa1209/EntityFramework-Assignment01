using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Entities;
using Microsoft.EntityFrameworkCore;
namespace demo.Contexts
{
    //db Context :container of Database
                  //deal with database throught it
                  //have more than dbContext
    internal class EnterPriceDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data source = . ; Initial Catalog = EnterPrice ; Integrated Security = true"); //old way
            optionsBuilder.UseSqlServer("Server = . ; Database = EnterPrice ; Trusted_Connection = true");
         }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Products> Products { get; set; }
        #region fluent apis
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.Name).IsRequired(false).HasDefaultValue("Test").HasAnnotation("MaxLength","50");
            base.OnModelCreating(modelBuilder);
        } 
        #endregion

    }
}
