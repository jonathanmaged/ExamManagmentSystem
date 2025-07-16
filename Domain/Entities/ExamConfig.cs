using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class ExamConfig : AuditableEntity
    {
        public double HardPercentage { get; set; }
        public double MediumPercentage { get; set; }
        public double EasyPercentage { get; set; }
        public int TotalQuestions { get; set; }
        public TimeSpan Duration { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<ExamInstance> ExamInstances { get; set; }
    }
}
