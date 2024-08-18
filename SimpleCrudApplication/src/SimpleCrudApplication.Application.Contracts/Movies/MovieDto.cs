using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace SimpleCrudApplication.Movies
{
    public class MovieDto : AuditedEntityDto<Guid>
    {
        public string movieName { get; set; }
        public string movieDescription {  get; set; }
        public string movieImageUrl { get; set; }
    }
}
