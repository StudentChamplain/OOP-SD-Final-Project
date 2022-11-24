using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Movie
    {
        private string movieId;
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

        public int MovieId { get { return movieId; } }

        public string Title { get { return title; } set { title = value; } }

        public string Genre { get { return genre; } set { genre = value; } }

        public string Minutes { get { return minutes; } set { minutes = value; } }
    }
}
