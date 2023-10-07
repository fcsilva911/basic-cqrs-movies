using BasicCQRSMovies.Library.Models;
using MediatR;

namespace BasicCQRSMovies.Library.Commands
{
    public record AddMovieCommand(MovieModel model) : IRequest<MovieModel>;

}
