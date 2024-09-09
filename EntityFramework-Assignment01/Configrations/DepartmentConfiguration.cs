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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // One-to-Many: Department - Student
            builder.HasMany(d => d.Students)
                   .WithOne(s => s.Department)
                   .HasForeignKey(s => s.Dep_ID)
                   .OnDelete(DeleteBehavior.NoAction);  // Prevent cascade delete

            // One-to-Many: Department - Instructor
            builder.HasMany(d => d.Instructors)
                   .WithOne(i => i.Department)
                   .HasForeignKey(i => i.Dept_ID)
                   .OnDelete(DeleteBehavior.NoAction);  // Prevent cascade delete

            // One-to-One: Department - Instructor
            builder.HasOne(d => d.Instructor)
                   .WithMany()  // Assuming Instructor has multiple departments, adjust if needed
                   .HasForeignKey(d => d.Ins_ID)
                   .OnDelete(DeleteBehavior.Restrict);  // Restrict delete for one-to-one
        }
    }
}
