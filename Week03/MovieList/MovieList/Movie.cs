using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        string title;
        int release;
        string director;
        string genre;
        int length;

        public Movie(string title, int release, string director, string genre, int length)
        {
            this.title = title;
            this.release = release;
            this.director = director;
            this.genre = genre;
            this.length = length;
        }

        public string ShowMovieInfo()
        {
            string MovieInfo = $"The movie name is {this.title} and the release date is {this.release}. The genre is {this.genre} and the director is {this.director}. It is {this.length} minutes long.";
            return MovieInfo;
        }
    }
}
