using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Student : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public StudyYear StudyYear { get; set; }
        public Semester Semester { get; set; }
        public bool IsActive { get; set; } = true;

        public string UserId { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<ExamInstance> ExamInstances { get; set; }
    }

}
