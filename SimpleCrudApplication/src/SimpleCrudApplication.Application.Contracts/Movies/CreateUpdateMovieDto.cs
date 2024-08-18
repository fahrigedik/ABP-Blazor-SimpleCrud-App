using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrudApplication.Movies
{
    public class CreateUpdateMovieDto
    {


        [Required]
        public string movieName { get; set; }

        [Required]
        public string movieDescription { get; set; }
        [Required]
        public string movieImageUrl { get; set; }
    }
}
