using OOP_Design_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SD_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a basic test <see cref="User"/>.
        /// </summary>
        /// <returns></returns>
        private User CreateTestUser()
        {
            User user = new User(000111, "Bob", "MacDonald");

            return user;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            User.ActiveUser = CreateTestUser();

            Screen2Form screen2Test = new Screen2Form();
            screen2Test.ShowDialog();
        }
    }
}
