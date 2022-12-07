using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{/// <summary>
/// Class that holds the SQLConnection 
/// </summary>
    internal  class DBConnection
    {
        /// <summary>
        /// Static method that returns the sql connection so we can get the information and add information to the database 
        /// </summary>
        /// <returns></returns>
        internal static SqlConnection getInstance()

        {

            string connstring = "Data Source = (LocalDB)\\MSSQLLocalDB; " +
                   "AttachDbFilename = C:\\xyz\\Project Database.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            return con;

        }
    }
}
