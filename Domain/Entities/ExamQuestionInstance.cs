using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class ExamQuestionInstance : BaseEntity
    {
        public int QuestionOrder { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int ExamInstanceId { get; set; }
        public ExamInstance ExamInstance { get; set; }

        public int? AnswerId { get; set; }
        public Answer Answer { get; set; }
        public bool? IsCorrectlyAnswered { get; set; }
    }

}
