using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Manager : User
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <remarks>Assigns itself the role of "Manager".</remarks>
        public Manager() 
        {
            this.Role = "Manager";
        }
    }
}
