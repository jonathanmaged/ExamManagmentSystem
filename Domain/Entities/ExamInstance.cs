using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class ExamInstance : AuditableEntity
    {
        public ExamStatus Status { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public double? Score { get; set; }
        public bool IsPassed { get; set; } =false;

        public int ExamConfigurationId { get; set; }
        public ExamConfig ExamConfiguration { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public ICollection<ExamQuestionInstance> ExamQuestionInstances { get; set; }
    }

}
