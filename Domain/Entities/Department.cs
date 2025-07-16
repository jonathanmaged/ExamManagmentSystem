using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        public ICollection<Student> Students { get; set; }
    }

}
