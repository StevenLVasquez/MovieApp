using System.Text.Json.Serialization;

namespace MovieApp.Models
{
    public class Movie
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        public string ImageUrl => $"https://image.tmdb.org/t/p/w500{PosterPath}";
    }
}
