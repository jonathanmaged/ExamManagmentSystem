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
    internal class ExamInstanceConfiguration : IEntityTypeConfiguration<ExamInstance>
    {
        public void Configure(EntityTypeBuilder<ExamInstance> builder)
        {
            builder.HasOne(q => q.ExamConfiguration)
                .WithMany(q => q.ExamInstances)
                .HasForeignKey(q => q.ExamConfigurationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(q => q.Student)
                .WithMany(q => q.ExamInstances)
                .HasForeignKey(q => q.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
