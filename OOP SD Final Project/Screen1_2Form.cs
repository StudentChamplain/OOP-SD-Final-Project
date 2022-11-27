using OOP_SD_Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Design_Project
{
    public partial class Screen1_2Form : Form
    {
        public Screen1_2Form()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();


        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();

        }



    }
}
