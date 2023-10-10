using BasicCQRSMovies.Library.Commands;
using BasicCQRSMovies.Library.DTOs;
using BasicCQRSMovies.Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BasicCQRSMovies.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<MovieReadDTO>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieReadDTO>> Get(Guid id)
        {
            var movie = await _mediator.Send(new GetMovieByIdQuery(id));
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        public async Task<MovieReadDTO> Post(MovieCreateDTO movie)
        {
            return await _mediator.Send(new AddMovieCommand(movie));
        }
    }
}