using BasicCQRSMovies.Library.DTOs;
using MediatR;

namespace BasicCQRSMovies.Library.Queries
{
    public record GetMovieListQuery() : IRequest<List<MovieReadDTO>>;

}
