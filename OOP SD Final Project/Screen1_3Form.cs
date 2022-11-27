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
    public partial class Screen1_3Form : Form
    {
        public Screen1_3Form()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {

            if( false/*USER IS PART OF THE CLIENTS*/)
            {
                this.Hide();

                Screen7Form form7 = new Screen7Form();
                form7.Show();
            }
            else if(true /*USER IS PART OF THE MANAGERS*/)
            {
                this.Hide();
                Screen2Form form2 = new Screen2Form();
                form2.Show();

            }



        }

        private void backButton_Click(object sender, EventArgs e)
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
