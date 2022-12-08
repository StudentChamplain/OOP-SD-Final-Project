using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    /// <summary>
    /// Class representing a user.
    /// </summary>
    /// <remarks>Used for displaying the information of the logged-in user.</remarks>
    public class User
    {
        private int userId;
        private string firstName;
        private string lastName;

        private static User activeUser;

        /// <summary>
        /// Constructor.
        /// </summary>
        public User(int userId, string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// The unique ID associated with the User.
        /// </summary>
        public int UserId { get { return userId; } set { userId = value; } }
        
        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName { get { return firstName; } set { firstName = value; } }

        /// <summary>
        /// The user's last name.
        /// </summary>
        private string LastName { get { return lastName; } set { lastName = value; } }

        /// <summary>
        /// The user's full name.
        /// </summary>
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        /// <summary>
        /// Contains the information of the user currently logged into the application.
        /// </summary>
        public static User ActiveUser { get { return activeUser; } set { activeUser = value; } }

        /// <summary>
        /// Returns the <see cref="UserId"/> as a string.
        /// </summary>
        /// <returns>A 6-character string representing the <see cref="UserId"/>.</returns>
        public string StringifyId()
        {
            string userIdString = UserId.ToString().PadLeft(6, '0');

            return userIdString;
        }
    }
}
