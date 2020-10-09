using System;

namespace CQRS.Application.Commands.AddStudent
{
    public class AddStudentInputModel
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
