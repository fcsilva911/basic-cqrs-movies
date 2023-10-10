using AutoMapper;
using BasicCQRSMovies.Library.DTOs;
using BasicCQRSMovies.Library.Models;

namespace BasicCQRSMovies.Library.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieModel, MovieReadDTO>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name));

            CreateMap<MovieCreateDTO, MovieModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Cost,
                    opt => opt.MapFrom(src => src.Cost));
        }
    }
}
