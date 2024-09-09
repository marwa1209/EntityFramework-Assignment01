using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Entities
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public int? Dept_ID { get; set; }
        #region Assignment02
        public Department? Department { get; set; }  // Navigation property
        public ICollection<Course_Inst> CourseInstructors { get; set; } = new HashSet<Course_Inst>();
        #endregion
    }
}
