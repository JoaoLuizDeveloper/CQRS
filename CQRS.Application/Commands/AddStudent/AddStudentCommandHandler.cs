using CQRS.Domain.Entities;
using CQRS.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Application.Commands.AddStudent
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Unit>
    {
        private readonly IStudentRepository _studentRepository;
        public AddStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<Unit> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student(request.FullName, request.BirthDate);

            _studentRepository.Add(student);

            return Task.FromResult(Unit.Value);
        }
    }
}
