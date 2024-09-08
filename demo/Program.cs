using demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterPriceDbContext enterPriceDbContext = new EnterPriceDbContext();
            //enterPriceDbContext.Employees.Add();

            ///Apply Migration To Database :EF=>c# to sql statements
            ///1.Code
            enterPriceDbContext.Database.Migrate(); //apply ups of all unapplied migration
            ///2. package manager console
            ///


            /// Ef supports 4 ways for mapping classes to database [Tables | Views] 
            ///1.By Convention (Default Behaviour) 
            ///2.Data Annotation=>flags
            ///


        }
    }
}
