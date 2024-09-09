using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Entities
{
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }

        #region Assignment02
        public Student? Student { get; set; }  // Navigation property
        public Course? Course { get; set; }  // Navigation property 
        #endregion
    }
}
