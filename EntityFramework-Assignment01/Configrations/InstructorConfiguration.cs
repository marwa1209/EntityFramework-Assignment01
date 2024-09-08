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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructor");
            builder.HasKey(i => i.ID);

            builder.Property(i => i.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(i => i.Bonus)
                .HasColumnType("decimal(18,2)");

            builder.Property(i => i.Salary)
                .HasColumnType("decimal(18,2)");

            builder.Property(i => i.HourRate)
                .HasColumnType("decimal(18,2)");

            builder.Property(i => i.Address)
                .HasMaxLength(250);
        }
    }

}
