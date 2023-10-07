using BasicCQRSMovies.Library.Models;
using MediatR;

namespace BasicCQRSMovies.Library.Queries
{
    public record GetMovieListQuery() : IRequest<List<MovieModel>>;

}
