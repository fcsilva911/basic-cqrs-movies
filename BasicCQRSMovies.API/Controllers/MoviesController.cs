using BasicCQRSMovies.Library.Commands;
using BasicCQRSMovies.Library.Models;
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
        public async Task<List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieModel>> Get(int id)
        {
            var movie = await _mediator.Send(new GetMovieByIdQuery(id));
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        public async Task<MovieModel> Post(MovieModel movie)
        {
            return await _mediator.Send(new AddMovieCommand(movie));
        }
    }
}