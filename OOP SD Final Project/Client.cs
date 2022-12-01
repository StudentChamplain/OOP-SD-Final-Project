using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Client : User
    {
        private List<Ticket> ticketList;


        /// <summary>
        /// Constructor
        /// </summary>
        /// /// <remarks>Assigns object the role of "Client".</remarks>
        /// <param name="currentDate"></param>
        public Client(int userId, string firstName, string lastName, string email, string password) : base(userId, firstName, lastName, email, password) {
            this.SignUpDate = DateTime.Now; 
            this.Role = "Client";
        }



        /// <summary>
        /// Date the user created their account.
        /// </summary>
        private DateTime SignUpDate { get; }

        private void BuyTicket()
        {
            // TODO
        }
    }
}
