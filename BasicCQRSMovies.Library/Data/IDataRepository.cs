using BasicCQRSMovies.Library.Models;

namespace BasicCQRSMovies.Library.Data
{
    public interface IDataRepository
    {
        List<MovieModel> GetMovies();
        MovieModel GetMovie(int id);
        MovieModel AddMovie(MovieModel movie);
    }
}
