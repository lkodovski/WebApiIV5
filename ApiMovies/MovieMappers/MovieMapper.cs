using ApiMovies.Models;
using ApiMovies.Models.Dtos;
using AutoMapper;


namespace ApiMovies.MovieMappers
{
    public class MovieMapper : Profile
    {
        public MovieMapper()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
        }
    }
}
