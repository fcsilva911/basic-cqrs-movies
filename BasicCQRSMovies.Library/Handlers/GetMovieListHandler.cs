using AutoMapper;
using BasicCQRSMovies.Library.Data;
using BasicCQRSMovies.Library.DTOs;
using BasicCQRSMovies.Library.Queries;
using MediatR;

namespace BasicCQRSMovies.Library.Handlers
{
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieReadDTO>>
    {
        private readonly IDataRepository _dataRepository;
        private readonly IMapper _mapper;

        public GetMovieListHandler(IDataRepository dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        public Task<List<MovieReadDTO>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            var movies = _dataRepository.GetMovies();
            return Task.FromResult(_mapper.Map<List<MovieReadDTO>>(movies));
        }
    }
}
