using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; set; }
        public Difficulty Difficulty { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public ICollection<Answer> Answers { get; set; }
        public ICollection<ExamQuestionInstance> ExamQuestionInstances { get; set; }
    }

}
