using BasicCQRSMovies.Library.DTOs;
using MediatR;

namespace BasicCQRSMovies.Library.Commands
{
    public record AddMovieCommand(MovieCreateDTO movie) : IRequest<MovieReadDTO>;

}
