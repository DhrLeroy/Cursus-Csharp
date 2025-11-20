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
        void SaveMovie(Movie movie);
    }
}
