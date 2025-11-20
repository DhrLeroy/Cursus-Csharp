using MyMovieApp_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieApp_Data
{
    public interface IMovieData
    {
        void SaveMovie(Movie movie);
    }
}
