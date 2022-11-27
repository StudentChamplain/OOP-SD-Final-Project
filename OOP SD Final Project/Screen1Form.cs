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
    public partial class Screen1Form : Form
    {
        public Screen1Form()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Screen1_1Form form = new Screen1_1Form();
            form.ShowDialog();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Screen1_3Form form = new Screen1_3Form();
            form.ShowDialog();


        }
    }
}
