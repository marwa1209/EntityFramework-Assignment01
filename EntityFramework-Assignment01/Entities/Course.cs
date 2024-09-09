using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Entities
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int Duration { get; set; }

        public int? Top_ID { get; set; }

        #region Assignment02

        public Topic? Topic { get; set; }  // Navigation property
        public ICollection<Stud_Course> StudCourses { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Inst> CourseInstructors { get; set; }=new HashSet<Course_Inst>();
        #endregion
    }
}
