using IMovieLogic;
using MyMovieApp_classes;
using MyMovieApp_Data;

namespace MovieLogic
{
    public class MovieController : IMovieController
    {
        private IMovieData data;

        public MovieController(IMovieData data)
        {
            this.data = data;
        }

        public List<Movie> GetAllMovies()
        {
            return data.GetAllMovies();
        }

        public void SaveMovie(Movie movie)
        {
            data.SaveMovie(movie);
        }
    }
}
