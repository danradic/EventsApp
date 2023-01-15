using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Attendance.Commands.UpdateAttendance
{
    public class UpdateAttendanceCommand : IRequest<Result<Unit>>
    {
        public Guid Id { get; set; }
    }
}