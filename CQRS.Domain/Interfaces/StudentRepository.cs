using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CQRS.Domain.Interfaces
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            
        }

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("luis", DateTime.Now)
            };
        }
    }
}
