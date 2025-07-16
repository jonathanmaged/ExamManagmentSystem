using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal class DepartmentSubjectConfiguration : IEntityTypeConfiguration<DepartmentSubject>
    {
        public void Configure(EntityTypeBuilder<DepartmentSubject> builder)
        {

            builder.HasOne(q => q.Subject)
                .WithMany(q => q.DepartmentSubjects)
                .HasForeignKey(q => q.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(q => q.Department)
                .WithMany(q => q.DepartmentSubjects)
                .HasForeignKey(q => q.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(q => 
                new {q.DepartmentId, q.StudyYear, q.Semester, q.SubjectId }
                ).IsUnique();
        }
    }
}
