using BasicCQRSMovies.Library.Models;

namespace BasicCQRSMovies.Library.Data
{
    public class DataRepository : IDataRepository
    {
        private static List<MovieModel> _movies = new()
        {
            new MovieModel { Id = Guid.Parse("45989fa7-f556-4273-abdc-a8620e298769"), Name = "Test Movie 1", Cost = 200m },
            new MovieModel { Id = Guid.Parse("24735295-2275-445f-8e3d-160eee91a1b4"), Name = "Test Movie 2", Cost = 300m }
        };

        public MovieModel AddMovie(MovieModel movie)
        {
            _movies.Add(movie);
            return movie;
        }

        public MovieModel GetMovie(Guid id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            return movie;
        }

        public List<MovieModel> GetMovies()
        {
            return _movies;
        }
    }
}
