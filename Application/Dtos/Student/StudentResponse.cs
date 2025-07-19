using Domain.Enums;

namespace Application.Dtos.Student
{
    public class StudentResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public StudyYear StudyYear { get; set; }
        public Semester Semester { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}