using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(q => q.Department)
                .WithMany(q => q.Students)
                .HasForeignKey(q => q.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<AppUser>()
                .WithOne()
                .HasForeignKey<Student>(q => q.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(q => q.NationalId).IsUnique();
            builder.HasIndex(q => q.UserId).IsUnique();

        }
    }
}
