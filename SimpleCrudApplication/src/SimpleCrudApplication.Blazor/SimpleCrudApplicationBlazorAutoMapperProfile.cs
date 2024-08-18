using AutoMapper;
using SimpleCrudApplication.Movies;

namespace SimpleCrudApplication.Blazor;

public class SimpleCrudApplicationBlazorAutoMapperProfile : Profile
{
    public SimpleCrudApplicationBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.

        CreateMap<MovieDto, CreateUpdateMovieDto>();
    }
}
