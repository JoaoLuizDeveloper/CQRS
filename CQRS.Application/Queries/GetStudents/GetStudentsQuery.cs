using MediatR;
using System.Collections.Generic;

namespace CQRS.Application.Queries.GetStudents
{
    public class GetStudentsQuery : IRequest<List<GetStudentsViewModel>>
    {
    }
}
