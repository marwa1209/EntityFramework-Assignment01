using EntityFramework_Assignment01.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Assignment01.Configrations
{

    public class CourseInstructorConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            // Many-to-Many: Course - Instructor
            builder.HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            builder.HasOne(ci => ci.Instructor)
                   .WithMany(i => i.CourseInstructors)
                   .HasForeignKey(ci => ci.Inst_ID);

            builder.HasOne(ci => ci.Course)
                   .WithMany(c => c.CourseInstructors)
                   .HasForeignKey(ci => ci.Course_ID);
        }
    }
}
