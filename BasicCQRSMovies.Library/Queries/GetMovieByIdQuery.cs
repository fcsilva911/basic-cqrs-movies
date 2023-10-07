using BasicCQRSMovies.Library.Models;
using MediatR;

namespace BasicCQRSMovies.Library.Queries
{
    public record GetMovieByIdQuery(int id) : IRequest<MovieModel>;
}
