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
            builder.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            builder.HasOne<Student>()
                .WithMany()
                .HasForeignKey(sc => sc.Stud_ID);

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey(sc => sc.Course_ID);
        }
    }

}
