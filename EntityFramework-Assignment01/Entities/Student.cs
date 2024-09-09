﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int? Dep_ID { get; set; }
        #region Assignment02
        public Department? Department { get; set; }  // Navigation property
        public ICollection<Stud_Course> StudCourses { get; set; } =new HashSet<Stud_Course>();
        #endregion
    }
}
