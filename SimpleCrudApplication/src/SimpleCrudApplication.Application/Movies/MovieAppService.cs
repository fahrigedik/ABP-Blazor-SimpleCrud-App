using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SimpleCrudApplication.Movies
{
    public class MovieAppService : CrudAppService<Movie,MovieDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateMovieDto>, IMovieAppService
    {
        public MovieAppService(IRepository<Movie,Guid> repository) : base(repository)
        {
                
        }
    }
}
