using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Movie
    {
        private int movieId;
        private string title;
        private string genre;
        private string minutes;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">The movie's title</param>
        /// <param name="genre">The movie's genre</param>
        /// <param name="minutes">The movie's length in minutes</param>
        public Movie(string title, string genre, string minutes)
        {
            Title = title;
            Genre = genre;
            Minutes = minutes;
        }

        /// <summary>
        /// The unique ID associated with the Movie.
        /// </summary>
        public int MovieId { get { return movieId; } }

        /// <summary>
        /// The title of the movie.
        /// </summary>
        public string Title { get { return title; } set { title = value; } }

        /// <summary>
        /// The movie's genre.
        /// </summary>
        public string Genre { get { return genre; } set { genre = value; } }

        /// <summary>
        /// The length of the movie in minutes.
        /// </summary>
        public string Minutes { get { return minutes; } set { minutes = value; } }
    }
}
