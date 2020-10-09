using CQRS.Domain.Entities;
using System.Collections.Generic;

namespace CQRS.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> GetAll();
    }
}
