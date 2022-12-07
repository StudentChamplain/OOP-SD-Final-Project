﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class ShowTime
    {
        private int showTimeId;
        private Movie movie;
        private List<Ticket> ticketList;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ShowTime()
        {

        }

        /// <summary>
        /// The unique ID associated with the Showtime.
        /// </summary>
        public int ShowTimeId { get { return showTimeId; } set { showTimeId = value; } }

        /// <summary>
        /// The Movie that will be shown at the Showtime.
        /// </summary>
        public Movie Movie { get { return movie; } set { movie = value; } }

        /// <summary>
        /// The Room the Showtime will be held in.
        /// </summary>

        /// <summary>
        /// Return the remaining amount of available seats for the Showtime. 
        /// </summary>
    }
}
