using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Demo_Assignment03.inheritanceExample.Models
{
    public class PartTimeEmployee:Employee
    {
        public int NumbersOfHours { get; set; }
        public double HourRate { get; set; }
    }
}
