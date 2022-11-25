using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Ticket
    {
        private int ticketId;
        private ShowTime showTime;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Ticket()
        {

        }

        /// <summary>
        /// The unique ID associated with the Ticket.
        /// </summary>
        public int TicketId { get { return ticketId; } set { ticketId = value; } }

        /// <summary>
        /// The ShowTime associated with the Ticket.
        /// </summary>
        public ShowTime ShowTime { get { return showTime; } set { showTime = value; } }
    }
}
