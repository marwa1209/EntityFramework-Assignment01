using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entities
{
/// Ef supports 4 ways for mapping classes to database [Tables | Views] 
///1.By Convention (Default Behaviour) 
///2.supports 4 ways for mapping classes to database [Tables | Views] 




    //Entity
    //Domain Model
    //Model
    //POCO Class [Plain Old Clr Object]
    internal class Employee
    {
        public int Id { get; set; }//public numeric property named as [Id|EmployeeId] =>PK [Identity Constraints(1,1)]
        public string? Name { get; set; }//refrence type =>alow null so it is not mandatory from 6 => changed to be required
        //to make the neame allow null i will make it nullabe with ?
        public decimal Salary { get; set; } //value type => not allow null required 
                                            //decimal(18,2)
        public int? Age { get; set; } //Nullable int :Allow Null [optional]
                                      //Int
    }
}
