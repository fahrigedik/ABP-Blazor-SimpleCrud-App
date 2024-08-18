using SimpleCrudApplication.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SimpleCrudApplication
{
    public class MovieDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Movie, Guid> _movieRepository;

        public MovieDataSeederContributor(IRepository<Movie, Guid> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _movieRepository.GetCountAsync() <= 0)
            {
                await _movieRepository.InsertAsync(
                    new Movie
                    {
                        movieName = "Platform",
                        movieDescription = "Platform",
                        movieImageUrl = "https://filmleroner.com/img/filmler/the-platform-60d86.jpg"
                    },
                    autoSave: true
                );
            }
        }
    }
}
