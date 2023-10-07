using BasicCQRSMovies.Library.Commands;
using BasicCQRSMovies.Library.Data;
using BasicCQRSMovies.Library.Models;
using MediatR;

namespace BasicCQRSMovies.Library.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, MovieModel>
    {
        private readonly IDataRepository _dataRepository;

        public AddMovieHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<MovieModel> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddMovie(request.model));
        }
    }
}
