using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediaTrAspNetCore.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MediaTrAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }

        [HttpPost("Register")]
        public ActionResult Register(EventoCommand evento)
        {
            var id = _mediator.Send(evento).Result;
            return Ok(id);
        }
    }
}
