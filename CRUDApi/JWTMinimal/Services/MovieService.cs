using JWTMinimal.Models;
using JWTMinimal.Repositories;

namespace JWTMinimal.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);
            return movie;
        }

        public bool Delete(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            if (movie is null) return false;
            MovieRepository.Movies.Remove(movie);
            return true;
        }

        public Movie get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            if(movie is null) return null;
            return movie;
        }

        public List<Movie> GetAll()
        {
            var movie = MovieRepository.Movies;
            return movie;
        }

        public Movie Update(Movie movie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(x => x.Id == movie.Id);
            if(oldMovie is null) return null;
            oldMovie.Title = movie.Title;
            oldMovie.Rating = movie.Rating;
            oldMovie.Description = movie.Description;
            return movie;
        }
    }
}
