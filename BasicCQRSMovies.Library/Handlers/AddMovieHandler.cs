using AutoMapper;
using BasicCQRSMovies.Library.Commands;
using BasicCQRSMovies.Library.Data;
using BasicCQRSMovies.Library.DTOs;
using BasicCQRSMovies.Library.Models;
using MediatR;

namespace BasicCQRSMovies.Library.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, MovieReadDTO>
    {
        private readonly IDataRepository _dataRepository;
        private readonly IMapper _mapper;

        public AddMovieHandler(IDataRepository dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        public Task<MovieReadDTO> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            var movieModel = _mapper.Map<MovieModel>(request.movie);
            var createdMovieModel = _dataRepository.AddMovie(movieModel);
            var createdMovieDTO = _mapper.Map<MovieReadDTO>(createdMovieModel);
            return Task.FromResult(createdMovieDTO);
        }
    }
}
