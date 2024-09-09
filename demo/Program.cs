using demo.Contexts;
using demo.Entities;
using Microsoft.EntityFrameworkCore;

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
            Employee employee01 = new Employee() { Name = "Marwa", Age = 23, Email = "marwa@gagrrr.com", Salary = 20000, PhoneNumbert = "0122373747" };
            Employee employee02 = new Employee() { Name = "Marwan", Age = 24, Email = "marwan@gag.com", Salary = 20000, PhoneNumbert = "0122373747" };
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
            enterPriceDbContext.Employees.Remove(Employee);
            Console.WriteLine(enterPriceDbContext.Entry(Employee).State); //deleted
            enterPriceDbContext.SaveChanges();
            Console.WriteLine(enterPriceDbContext.Entry(Employee).State); //deleted


            #endregion
            #endregion
            #endregion
        }
    }
}
