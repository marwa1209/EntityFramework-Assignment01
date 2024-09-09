using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Entities
{
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        #region Assignment02
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        #endregion    
    }
}
