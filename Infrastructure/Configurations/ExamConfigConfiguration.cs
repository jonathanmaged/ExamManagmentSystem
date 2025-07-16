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
    internal class ExamConfigConfiguration : IEntityTypeConfiguration<ExamConfig>
    {
        public void Configure(EntityTypeBuilder<ExamConfig> builder)
        {
            builder.HasOne(q => q.Subject)
                .WithMany(q => q.ExamsConfiguration)
                .HasForeignKey(q => q.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(q => q.SubjectId).IsUnique();
        }
    }
}
