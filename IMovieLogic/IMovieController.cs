using MyMovieApp_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovieLogic
{
    public interface IMovieController
    {
        List<Movie> GetAllMovies();
        void SaveMovie(Movie movie);
    }
}
