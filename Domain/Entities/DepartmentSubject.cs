using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class DepartmentSubject : BaseEntity
    {
        public StudyYear StudyYear { get; set; }
        public Semester Semester { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
   
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }

}
