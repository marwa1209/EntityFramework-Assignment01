using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entities
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();
        //navigiotional property => many
    }
}
