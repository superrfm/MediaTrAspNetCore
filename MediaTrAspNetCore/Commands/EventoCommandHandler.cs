using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediaTrAspNetCore.Commands
{
    public class EventoCommandHandler
         : IRequestHandler<EventoCommand, int>
    {
        public Task<int> Handle(EventoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Id);
        }
    }
}
