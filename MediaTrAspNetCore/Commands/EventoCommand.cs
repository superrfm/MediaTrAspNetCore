using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTrAspNetCore.Commands
{
    public class EventoCommand
        : IRequest<int>
    {
        public int Id { get; set; }

        public EventoCommand()
        {
            Id = new Random().Next(100);
        }
    }
}
