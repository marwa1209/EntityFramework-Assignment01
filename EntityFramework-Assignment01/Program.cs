using EntityFramework_Assignment01.Context;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext iTIDbContext = new ITIDbContext();
            iTIDbContext.Database.Migrate();

        }
    }
}
