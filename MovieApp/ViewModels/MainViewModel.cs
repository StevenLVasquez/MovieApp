using System.Collections.ObjectModel;
using MovieApp.Models;
using MovieApp.Services;

namespace MovieApp.ViewModels
{
    public class MainViewModel
    {
        private readonly MovieService _movieService;

        public ObservableCollection<Movie> FeaturedMovies { get; set; }
        public ObservableCollection<Movie> PopularMovies { get; set; }

        public MainViewModel()
        {
            _movieService = new MovieService();
            FeaturedMovies = new ObservableCollection<Movie>();
            PopularMovies = new ObservableCollection<Movie>();

            LoadMovies();
        }

        private async void LoadMovies()
        {
            var trendingMovies = await _movieService.GetTrendingMoviesAsync();
            var popularMovies = await _movieService.GetPopularMoviesAsync();

            if (trendingMovies.Count > 0)
            {
                FeaturedMovies.Clear();
                foreach (var movie in trendingMovies)
                    FeaturedMovies.Add(movie);
            }

            if (popularMovies.Count > 0)
            {
                PopularMovies.Clear();
                foreach (var movie in popularMovies)
                    PopularMovies.Add(movie);
            }
        }
    }
}
