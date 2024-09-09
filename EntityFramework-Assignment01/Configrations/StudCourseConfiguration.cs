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
    public class StudCourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            // Many-to-Many: Student - Course
            builder.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.StudCourses)
                   .HasForeignKey(sc => sc.Stud_ID);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.StudCourses)
                   .HasForeignKey(sc => sc.Course_ID);
        }
    }

}
