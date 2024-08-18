using AutoMapper;
using SimpleCrudApplication.Movies;

namespace SimpleCrudApplication;

public class SimpleCrudApplicationApplicationAutoMapperProfile : Profile
{
    public SimpleCrudApplicationApplicationAutoMapperProfile()
    {

        CreateMap<Movie, MovieDto>();
        CreateMap<CreateUpdateMovieDto, Movie>();
        
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
