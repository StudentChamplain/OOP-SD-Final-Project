using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    public class User
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string role;

        /// <summary>
        /// Constructor.
        /// </summary>
        public User()
        {

        }

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
        /// The user's email address.
        /// </summary>
        private string Email { get { return email; } set { email = value; } }

        /// <summary>
        /// The user's account password.
        /// </summary>
        private string Password { get { return password; } set { password = value; } }

        /// <summary>
        /// Indicates if the user is a Client or a Manager.
        /// </summary>
        public string Role { get { return role; } set { role = value; } }

        public string StringifyId()
        {
            string userIdString = UserId.ToString().PadLeft(6, '0');

            return userIdString;
        }
    }
}
