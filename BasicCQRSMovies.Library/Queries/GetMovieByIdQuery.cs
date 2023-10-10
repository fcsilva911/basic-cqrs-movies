using BasicCQRSMovies.Library.DTOs;
using MediatR;

namespace BasicCQRSMovies.Library.Queries
{
    public record GetMovieByIdQuery(Guid id) : IRequest<MovieReadDTO>;
}
