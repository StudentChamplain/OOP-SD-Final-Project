using OOP_SD_Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods
{
    static class Extensions
    {
        public static void SetUserInfo(this Form form, Label idLabel, Label nameLabel)
        {
            idLabel.Text = User.ActiveUser.StringifyId();
            nameLabel.Text = User.ActiveUser.FullName;

        }
    }
}
