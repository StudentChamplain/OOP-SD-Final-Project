using OOP_SD_Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods
{
    /// <summary>
    /// Class to contain extension methods.
    /// </summary>
    static class Extensions
    {
        /// <summary>
        /// Extension method for the <see cref="Form"/> class.
        /// </summary>
        /// <remarks>Sets the <see cref="User.ActiveUser"/> Id and Name into the appropriate labels.</remarks>
        /// <param name="form"></param>
        /// <param name="idLabel">The label to display the user's Id.</param>
        /// <param name="nameLabel">The label to display the user's name.</param>
        public static void SetUserInfo(this Form form, Label idLabel, Label nameLabel)
        {
            idLabel.Text = User.ActiveUser.StringifyId();
            nameLabel.Text = User.ActiveUser.FullName;

        }
    }
}
