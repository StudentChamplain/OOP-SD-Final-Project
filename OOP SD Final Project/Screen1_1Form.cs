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
    public partial class Screen1_1Form : Form
    {
        public Screen1_1Form()
        {
            InitializeComponent();
        }

        private void signUpConfirmationButton_Click(object sender, EventArgs e)
        {
            Screen1_2Form form1_2 = new Screen1_2Form();
            form1_2.Show();
            this.Hide();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
        }

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen1Form form1 = new Screen1Form();
            form1.Show();

        }




    }
}
