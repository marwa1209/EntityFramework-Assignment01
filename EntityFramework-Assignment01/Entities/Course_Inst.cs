using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Entities
{
    public class Course_Inst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }
        #region Assignment02
        public Instructor? Instructor { get; set; }  // Navigation property
        public Course ?Course { get; set; }  // Navigation property 
        #endregion
    }
}
