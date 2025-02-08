using System.Net.Http.Json;
using MovieApp.Models;

namespace MovieApp.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Movie>> GetPopularMoviesAsync()
        {
            string url = $"{Helpers.Constants.BaseUrl}movie/popular?api_key={Helpers.Constants.ApiKey}&language=es-ES";

            var response = await _httpClient.GetFromJsonAsync<TmdbResponse>(url);
            return response?.Results ?? new List<Movie>();
        }

        public async Task<List<Movie>> GetTrendingMoviesAsync()
        {
            string url = $"{Helpers.Constants.BaseUrl}trending/movie/day?api_key={Helpers.Constants.ApiKey}&language=es-ES";

            var response = await _httpClient.GetFromJsonAsync<TmdbResponse>(url);
            return response?.Results ?? new List<Movie>();
        }
    }

    public class TmdbResponse
    {
        public List<Movie> Results { get; set; }
    }
}
