using BasicCQRSMovies.Library.Data;
using BasicCQRSMovies.Library.Models;
using BasicCQRSMovies.Library.Queries;
using MediatR;

namespace BasicCQRSMovies.Library.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, MovieModel>
    {
        private readonly IDataRepository _dataRepository;

        public GetMovieByIdHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<MovieModel> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movie = _dataRepository.GetMovie(request.id);
            return movie;
        }
    }
}
