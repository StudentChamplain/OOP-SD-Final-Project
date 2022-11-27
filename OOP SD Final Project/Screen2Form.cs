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
    public partial class Screen2Form : Form
    {
        public Screen2Form()
        {
            InitializeComponent();
        }

        private void consultMoviesButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            Screen3Form form3 = new Screen3Form();
            form3.Show();

        }

        private void consultScreeningsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen4Form form4 = new Screen4Form();
            form4.Show();

        }

        private void consultRoomsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen5Form form5 = new Screen5Form();
            form5.Show();

        }

        private void consultClientsButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            Screen6Form form6 = new Screen6Form();
            form6.Show();

        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen1Form form1 = new Screen1Form();
            form1.Show();

        }
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen1Form form1 = new Screen1Form();
            form1.Show();

        }
    }
}
