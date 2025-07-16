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
    internal class ExamQuestionInstanceConfiguration : IEntityTypeConfiguration<ExamQuestionInstance>
    {
        public void Configure(EntityTypeBuilder<ExamQuestionInstance> builder)
        {
            builder.HasOne(q => q.Answer)
                .WithMany(q => q.ExamQuestionInstances)
                .HasForeignKey(q => q.AnswerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(q => q.ExamInstance)
                .WithMany(q => q.ExamQuestionInstances)
                .HasForeignKey(q => q.ExamInstanceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(q => q.Question)
                .WithMany(q => q.ExamQuestionInstances)
                .HasForeignKey(q => q.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(q => 
                new { q.ExamInstanceId, q.QuestionId }
                ).IsUnique();

        }
    }
}
