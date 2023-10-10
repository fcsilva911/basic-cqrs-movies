using AutoMapper;
using BasicCQRSMovies.Library.Data;
using BasicCQRSMovies.Library.DTOs;
using BasicCQRSMovies.Library.Queries;
using MediatR;

namespace BasicCQRSMovies.Library.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, MovieReadDTO>
    {
        private readonly IDataRepository _dataRepository;
        private readonly IMapper _mapper;

        public GetMovieByIdHandler(IDataRepository dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        public async Task<MovieReadDTO> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movie = _dataRepository.GetMovie(request.id);
            return _mapper.Map<MovieReadDTO>(movie);
        }
    }
}
