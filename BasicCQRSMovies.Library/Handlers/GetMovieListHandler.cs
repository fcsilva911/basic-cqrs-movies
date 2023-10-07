using BasicCQRSMovies.Library.Data;
using BasicCQRSMovies.Library.Models;
using BasicCQRSMovies.Library.Queries;
using MediatR;

namespace BasicCQRSMovies.Library.Handlers
{
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepository _dataRepository;

        public GetMovieListHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetMovies());
        }
    }
}
