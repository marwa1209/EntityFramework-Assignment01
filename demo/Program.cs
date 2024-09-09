using demo.Contexts;
using demo.Demo_Assignment03.inheritanceExample.Contexts;
using demo.Demo_Assignment03.inheritanceExample.Models;
using demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo Session01
            //  EnterPriceDbContext enterPriceDbContext = new EnterPriceDbContext();
            //enterPriceDbContext.Employees.Add();
            ///Apply Migration To Database :EF=>c# to sql statements
            ///1.Code
            //   enterPriceDbContext.Database.Migrate(); //apply ups of all unapplied migration
            ///2. package manager console
            ///


            /// Ef supports 4 ways for mapping classes to database [Tables | Views] 
            ///1.By Convention (Default Behaviour) 
            ///2.Data Annotation=>flags
            ///3.Fluent Apis


            #endregion
            #region Demo Session02
            //try {
            ////crud=>query object model
            //}
            //finally {
            ////release //free //deallocate // dispose unmanaged resources
            //enterPriceDbContext.Dispose();
            //}
            //syntax sugar
            //using (EnterPriceDbContext enterPriceDbContext = new EnterPriceDbContext())
            //{

            //}
            //syntax sugar
            using EnterPriceDbContext enterPriceDbContext = new EnterPriceDbContext();
            //Employee employee01 = new Employee() { Name = "Marwa", Age = 23, Email = "marwa@gagrrr.com", Salary = 20000, PhoneNumbert = "0122373747" };
          //  Employee employee02 = new Employee() { Name = "Marwan", Age = 24, Email = "marwan@gag.com", Salary = 20000, PhoneNumbert = "0122373747" };
            //Crud
            #region CRUD
            #region INSERT
            //enterPriceDbContext.Employees.Add(employee01);
            //enterPriceDbContext.Employees.Add(employee02);
            //enterPriceDbContext.SaveChanges();
            // Console.WriteLine(enterPriceDbContext.Entry(employee01).State);//detached 
            #endregion
            var Employee = (from E in enterPriceDbContext.Employees
                            where E.EmpId == 1
                            select E).FirstOrDefault();
            #region READ
            // Console.WriteLine(Employee?.Name??"Not Found");
            #endregion
            #region UPDATE
            //var Employee = (from E in enterPriceDbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            // Console.WriteLine(enterPriceDbContext.Entry(Employee).State);
            //Employee.Name = "marora"; //updated locally
            //Console.WriteLine(enterPriceDbContext.Entry(Employee).State);
            //enterPriceDbContext.SaveChanges();

            #endregion
            #region Delete
            //enterPriceDbContext.Employees.Remove(Employee);
            //Console.WriteLine(enterPriceDbContext.Entry(Employee).State); //deleted
            //enterPriceDbContext.SaveChanges();
            //Console.WriteLine(enterPriceDbContext.Entry(Employee).State); //deleted


            #endregion
            #endregion
            #endregion
            #region Demo Sessiion03
            #region TPC[table per class]
            //using AppDbContext appDbContext = new AppDbContext();
            //FullTimeEmployee employee = new FullTimeEmployee() { Name = "Marwa", Address = "address", Email = "kdkdkdk@gsgs.com", Salary = 20000 };
            //FullTimeEmployee employee02 = new FullTimeEmployee() { Name = "Marwan", Address = "address", Email = "kdkdkdk@gsgs.com", Salary = 200000 };
            //PartTimeEmployee employee03 = new PartTimeEmployee() { Name = "Marwan", Address = "address", Email = "kdkdkdk@gsgs.com", HourRate = 2000 };
            //PartTimeEmployee employee04 = new PartTimeEmployee() { Name = "Marwan", Address = "address", Email = "kdkdkdk@gsgs.com", HourRate = 2000 };
            //appDbContext.Employees.Add(employee03);
            //appDbContext.Employees.Add(employee04);
            //appDbContext.SaveChanges(); 
            #endregion
            #region TPH
            using AppDbContext appDbContext = new AppDbContext();
            //FullTimeEmployee employee = new FullTimeEmployee() { Name = "Marwa", Address = "address", Email = "kdkdkdk@gsgs.com", Salary = 20000 };
            //FullTimeEmployee employee02 = new FullTimeEmployee() { Name = "Marwan", Address = "address", Email = "kdkdkdk@gsgs.com", Salary = 200000 };
            //PartTimeEmployee employee03 = new PartTimeEmployee() { Name = "Marwan", Address = "address", Email = "kdkdkdk@gsgs.com", HourRate = 2000 };
            //PartTimeEmployee employee04 = new PartTimeEmployee() { Name = "Marwan", Address = "address", Email = "kdkdkdk@gsgs.com", HourRate = 2000 };
            //appDbContext.Employees.Add(employee03);
            //appDbContext.Employees.Add(employee04);
            //appDbContext.Employees.Add(employee);
            //appDbContext.Employees.Add(employee02);
            //appDbContext.SaveChanges();
            //var result = appDbContext.Employees.OfType<FullTimeEmployee>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #endregion
        }
    }
}
