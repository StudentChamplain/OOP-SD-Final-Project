﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Client : User
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="currentDate"></param>
        public Client(DateTime currentDate)
        {
            this.SignUpDate = currentDate;
        }

        private DateTime SignUpDate { get; }
    }
}
