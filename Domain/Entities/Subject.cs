using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<ExamConfig> ExamsConfiguration { get; set; }
    }

}
